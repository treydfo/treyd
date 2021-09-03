using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;
using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;
using System.Text;
using System.Security.Cryptography;
using DataLibrary;
using treyd.Models;
using Newtonsoft.Json.Linq;
using System;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Components.Authorization;
using treyd.Shared;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using QuickPay.SDK;
using System.Collections.Generic;

namespace treyd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuickPayController : ControllerBase
    {
        private readonly IWebHostEnvironment environment;
        private IConfiguration _config;
        private IDataAccess _data;
        private QuickPayModel _qp;
        private PaymentModel _payment;
        private UserModel _user;
        private SubscriptionModel _subscription;

        private QuickPayClient QuickPayClient = new QuickPayClient(QuickPayConfig.API_KEY, QuickPayConfig.PRIVATE_KEY, QuickPayConfig.USER);

        public QuickPayController(IWebHostEnvironment environment, IConfiguration config)
        {
            this.environment = environment;
            _config = config;
            _data = new DataAccess();
            _qp = new QuickPayModel();
            _payment = new PaymentModel();
            _user = new UserModel();
            _subscription = new SubscriptionModel();
        }

        [HttpPost]
        public async Task<HttpResponseMessage> Get()
        {
            Task<string> sBody = null;

            using (var reader = new StreamReader(Request.Body))
            {
                sBody = reader.ReadToEndAsync();
            }

            string content = sBody.Result;
            byte[] bytes = Encoding.Default.GetBytes(content);
            content = Encoding.UTF8.GetString(bytes);

            string compute = QuickPayConfig.Sign(content);
            string checkSum = Request.Headers["QuickPay-Checksum-Sha256"];

            if (checkSum.Equals(compute))
            {
                JObject jObject = JObject.Parse(content);
                _qp = jObject.ToObject<QuickPayModel>();

                foreach (var operation in _qp.operations)
                {
                    if (operation.qp_status_code == "20000" || operation.qp_status_code == "30100")
                    {
                        if (_qp.type == "Payment")
                        {
                            await SavePayment();
                            await SaveOrder();
                        }
                        else if (_qp.type == "Subscription")
                        {
                            await SubscriptionMethod();
                        }

                        return new HttpResponseMessage(HttpStatusCode.Accepted);
                    }
                    else
                    {
                        if (_qp.variables.address != null && _qp.variables.email != null)
                        {
                            await DeleteUser(_qp.variables.email);
                        }
                    }
                }
            }
            else
            {
                if (_qp.variables.address != null && _qp.variables.email != null)
                {
                    await DeleteUser(_qp.variables.email);
                }

                return new HttpResponseMessage(HttpStatusCode.Unauthorized);
            }

            return new HttpResponseMessage(HttpStatusCode.Unauthorized);
        }

        protected async Task<bool> LoadUser()
        {
            try
            {
                string sql = "select * from users where Email = @Email";
                _user = await _data.QuerySingle<UserModel, dynamic>(sql, new { Email = _qp.variables.email }, _config.GetConnectionString("default"));

                return await Task.FromResult(true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                return await Task.FromResult(false);
            }
        }

        protected async Task<bool> LoadPayment()
        {
            try
            {
                string sql = "select * from payments where Created = @Created";
                _payment = await _data.QuerySingle<PaymentModel, dynamic>(sql, new { Created = _qp.created_at }, _config.GetConnectionString("default"));

                return await Task.FromResult(true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                return await Task.FromResult(false);
            }
        }

        protected async Task<bool> LoadSubscription()
        {
            try
            {
                string sql = "select * from users join subscriptions on users.UserID = subscriptions.UserID where Email = @email";
                _subscription = await _data.QuerySingle<SubscriptionModel, dynamic>(sql, new { Email = _qp.variables.email }, _config.GetConnectionString("default"));

                return await Task.FromResult(true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                return await Task.FromResult(false);
            }
        }

        protected async Task<bool> SavePayment()
        {
            await LoadUser();

            if (_user != null)
            {
                try
                {
                    string strAmount = _qp.link.amount.ToString();
                    string amount = strAmount.Substring(0, strAmount.Length - 2);

                    string sql = "insert into payments (PaymentNumber, Amount, Currency, Provider, UserID, Status, Type, Updated, Created)" +
                        "values (@PaymentNumber, @Amount, @Currency, @Provider, @UserID, @Status, @Type, @Updated, @Created);";

                    await _data.SaveData(sql, new
                    {
                        PaymentNumber = _qp.id,
                        Amount = amount,
                        Currency = _qp.currency,
                        Provider = _qp.acquirer,
                        UserID = _user.UserID,
                        Status = "Pending",
                        Type = _qp.type,
                        Updated = _qp.created_at,
                        Created = _qp.created_at
                    }
                    , _config.GetConnectionString("default"));

                    return await Task.FromResult(true);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);

                    return await Task.FromResult(false);
                }
            }

            return await Task.FromResult(false);
        }

        protected async Task<bool> SaveOrder()
        {
            await LoadPayment();

            if (_payment != null)
            {
                try
                {
                    string strAmount = _qp.link.amount.ToString();
                    string amount = strAmount.Substring(0, strAmount.Length - 2);

                    string sql = "insert into orders (OrderNumber, Total, UserID, PaymentID, DateOrdered)" +
                        "values (@OrderNumber, @Total, @UserID, @PaymentID, @DateOrdered);";

                    await _data.SaveData(sql, new
                    {
                        OrderNumber = long.Parse(_qp.order_id),
                        Total = amount,
                        UserID = _user.UserID,
                        PaymentID = _payment.PaymentID,
                        DateOrdered = _qp.created_at
                    }
                    , _config.GetConnectionString("default"));

                    return await Task.FromResult(true);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);

                    return await Task.FromResult(false);
                }
            }

            return await Task.FromResult(false);
        }



        protected async Task<bool> SubscriptionMethod()
        {
            await LoadUser();
            await LoadSubscription();

            if (_user != null)
            {
                // If this is a subscription update, delete the previous user subscription
                if (_qp.variables.is_update == "true")
                {
                    try
                    {
                        // Cancel the loaded subscription (the previous subscription of the user) on the QuickPay manager
                        await QuickPayClient.Subscriptions.Cancel(_subscription.SubscriptionNumber);
                        await DeleteSubscription(_subscription.SubscriptionNumber);
                        await SaveSubscription();

                        return await Task.FromResult(true);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);

                        return await Task.FromResult(false);
                    }
                }
                else if (_qp.variables.is_activation == "true" && _subscription.Status == "Cancelled")
                {
                    try
                    {
                        await DeleteSubscription(_subscription.SubscriptionNumber);
                        await SaveSubscription();

                        return await Task.FromResult(true);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);

                        return await Task.FromResult(false);
                    }
                }
                else
                {
                    await SaveSubscription();
                    await SaveAddress();
                    await SaveStore();
                }
            }

            return await Task.FromResult(false);
        }

        protected async Task<bool> SaveSubscription()
        {
            try
            {
                string strAmount = _qp.link.amount.ToString();
                string amount = strAmount.Substring(0, strAmount.Length - 2);

                string sql = "insert into subscriptions (SubscriptionNumber, Cardholder, Last4, ExpiryMonth, ExpiryYear, Type, Brand, Country, UserID, Status, SubscriptionFee, Updated, Created)" +
                    "values (@SubscriptionNumber, @Cardholder, @Last4, @ExpiryMonth, @ExpiryYear, @Type, @Brand, @Country, @UserID, @Status, @SubscriptionFee, @Updated, @Created);";

                await _data.SaveData(sql, new
                {
                    SubscriptionNumber = _qp.id,
                    Cardholder = _qp.metadata.issued_to,
                    Last4 = _qp.metadata.last4,
                    ExpiryMonth = _qp.metadata.exp_month,
                    ExpiryYear = _qp.metadata.exp_year,
                    Type = _qp.metadata.type,
                    Brand = _qp.metadata.brand,
                    Country = _qp.metadata.country,
                    UserID = _user.UserID,
                    Status = "Active",
                    SubscriptionFee = amount,
                    Updated = _qp.created_at,
                    Created = _qp.created_at
                }
                , _config.GetConnectionString("default"));

                return await Task.FromResult(true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                return await Task.FromResult(false);
            }
        }

        private async Task<bool> SaveAddress()
        {
            if (_user != null)
            {
                try
                {
                    string sql = "insert into addresses (Address, City, PostalCode, UserID, Updated, Registered)" +
                        "values (@Address, @City, @PostalCode, @UserID, @Updated, @Registered);";

                    await _data.SaveData(sql, new
                    {
                        Address = _qp.variables.address,
                        City = _qp.variables.city,
                        PostalCode = _qp.variables.postal_code,
                        UserID = _user.UserID,
                        Updated = _qp.created_at,
                        Registered = _qp.created_at
                    }
                    , _config.GetConnectionString("default"));

                    return await Task.FromResult(true);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);

                    return await Task.FromResult(false);
                }
            }

            return await Task.FromResult(false);
        }

        private async Task<bool> SaveStore()
        {
            if (_user != null)
            {
                try
                {
                    string sql = "insert into stores (Name, UserID, MainColor, CoverImagePath, StoreIconPath, Updated, Registered)" +
                        "values (@Name, @UserID, @MainColor, @CoverImagePath, @StoreIconPath, @Updated, @Registered);";

                    await _data.SaveData(sql, new
                    {
                        Name = _user.CompanyName,
                        UserID = _user.UserID,
                        MainColor = "#0e3976",
                        CoverImagePath = "",
                        StoreIconPath = "",
                        Updated = _qp.created_at,
                        Registered = _qp.created_at
                    }, _config.GetConnectionString("default"));

                    return await Task.FromResult(true);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);

                    return await Task.FromResult(false);
                }
            }

            return await Task.FromResult(false);
        }
        protected async Task<bool> DeleteSubscription(int subscriptionId)
        {
            try
            {
                string sql = "delete from subscriptions where SubscriptionNumber = @SubscriptionNumber";
                await _data.SaveData(sql, new { SubscriptionNumber = subscriptionId }, _config.GetConnectionString("default"));

                return await Task.FromResult(true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                return await Task.FromResult(false);
            }
        }

        protected async Task<bool> DeleteUser(string email)
        {
            try
            {
                string sql = "delete from users where Email = @Email";

                await _data.SaveData(sql, new { Email = email }, _config.GetConnectionString("default"));

                return await Task.FromResult(true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                return await Task.FromResult(false);
            }
        }
    }
}