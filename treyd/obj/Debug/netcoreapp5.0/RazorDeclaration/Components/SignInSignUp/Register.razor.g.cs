// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace treyd.Components.SignInSignUp
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\_Imports.razor"
using treyd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\_Imports.razor"
using treyd.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\_Imports.razor"
using treyd.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\_Imports.razor"
using treyd.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\_Imports.razor"
using treyd.Components.Category;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\_Imports.razor"
using treyd.Components.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\_Imports.razor"
using treyd.Components.Toolbars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\_Imports.razor"
using treyd.Components.Cart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\_Imports.razor"
using treyd.Components.Sidebars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\_Imports.razor"
using treyd.Components.Redirects;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\_Imports.razor"
using treyd.Components.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\_Imports.razor"
using treyd.Components.Alerts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\_Imports.razor"
using treyd.Components.SignInSignUp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\_Imports.razor"
using Syncfusion.Blazor.SplitButtons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\_Imports.razor"
using Syncfusion.Blazor.Cards;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\_Imports.razor"
using Syncfusion.Blazor.Spinner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\_Imports.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\_Imports.razor"
using BlazorPro.BlazorSize;

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\_Imports.razor"
using QuickPay.SDK.Models.Payments;

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\_Imports.razor"
using QuickPay.SDK.Models.Subscriptions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\SignInSignUp\Register.razor"
using DataLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\SignInSignUp\Register.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\SignInSignUp\Register.razor"
using Microsoft.AspNetCore.WebUtilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\SignInSignUp\Register.razor"
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\SignInSignUp\Register.razor"
using QuickPay.SDK;

#line default
#line hidden
#nullable disable
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 175 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\SignInSignUp\Register.razor"
       
    private UserRegisterModel User { get; set; }

    private UserModel SubscribedUser { get; set; }
    private UserModel NewCustomer { get; set; }
    private AuthModel Auth { get; set; }

    private QuickPayClient QuickPayClient = new QuickPayClient(QuickPayConfig.API_KEY, QuickPayConfig.PRIVATE_KEY, QuickPayConfig.USER);

    private List<UserModel> Users;

    private string subscriptionSection;
    private string registerSection;

    private string companyBtn;
    private string customerBtn;
    private string normalBtn;
    private string bestBtn;

    private string cName;
    private string fName;
    private string lName;
    private string fornavn;
    private string eftirnavn;

    private string emailErrMsg;
    private string companyErrMsg;
    private string subscriptionErrMsg;

    private string queryStringEmail = "";

    private bool displayAlert = false;

    private int subscriptionFee = 0;

    protected override async Task OnInitializedAsync()
    {
        var uri = NavigationManager.ToAbsoluteUri(NavigationManager.Uri);

        if (QueryHelpers.ParseQuery(uri.Query).TryGetValue("em", out var queryStringEmail))
        {
            this.queryStringEmail = queryStringEmail.First();
        }

        IsCustomer();

        if (this.queryStringEmail != null && this.queryStringEmail != "")
        {
            await VerifySubscription();
        }
    }

    public void IsCustomer()
    {
        User = null;
        User = new UserRegisterModel();

        fornavn = "Fornavn";
        eftirnavn = "Eftirnavn";

        User.CompanyName = "-";
        User.Role = "Customer";

        this.subscriptionSection = "display: none;";
        this.registerSection = "display: initial;";
        this.customerBtn = "active";
        this.companyBtn = "";
        this.cName = "display: none;";
        this.fName = "display: initial;";
        this.lName = "display: initial;";
        this.emailErrMsg = "display: none;";
        this.companyErrMsg = "display: none;";
        this.subscriptionErrMsg = "display: none;";
        this.normalBtn = "";
        this.bestBtn = "";
        this.subscriptionFee = 0;
    }

    public void IsCompany()
    {
        User = null;
        SubscribedUser = null;

        User = new UserRegisterModel();
        SubscribedUser = new UserModel();

        fornavn = "Fornavn ??byrgdarhavarans";
        eftirnavn = "Eftirnavn ??byrgdarhavarans";

        User.CompanyName = "";
        User.Role = "Company";

        this.subscriptionSection = "display: initial;";
        this.registerSection = "display: none;";
        this.customerBtn = "";
        this.companyBtn = "active";
        this.cName = "display: initial;";
    }

    public void Normal()
    {
        this.subscriptionErrMsg = "display: none;";
        this.normalBtn = "active";
        this.bestBtn = "";
        this.subscriptionFee = TreydFeesConfig.SUBSCRIPTION_FEE_NORMAL;
    }

    public void Best()
    {
        this.subscriptionErrMsg = "display: none;";
        this.bestBtn = "active";
        this.normalBtn = "";
        this.subscriptionFee = TreydFeesConfig.SUBSCRIPTION_FEE_BEST;
    }

    public void ValidateSubscription()
    {
        if (this.subscriptionFee != 0)
        {
            this.subscriptionSection = "display: none;";
            this.registerSection = "display: initial;";
        }
        else
        {
            this.subscriptionErrMsg = "display: initial;";
        }
    }

    public void BackToSubscription()
    {
        this.subscriptionErrMsg = "display: none;";
        this.subscriptionSection = "display: initial;";
        this.registerSection = "display: none;";
    }

    protected async Task<bool> LoadUser()
    {
        try
        {
            string sql = "select * from users where Email = @Email";
            NewCustomer = await _data.QuerySingle<UserModel, dynamic>(
                sql, new { Email = User.Email }, _config.GetConnectionString("default"));

            return await Task.FromResult(true);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);

            return await Task.FromResult(false);
        }
    }

    protected async Task<bool> LoadUsers()
    {
        try
        {
            string sql = "select * from users";
            Users = await _data.LoadData<UserModel, dynamic>(sql, new { }, _config.GetConnectionString("default"));

            return await Task.FromResult(true);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);

            return await Task.FromResult(false);
        }
    }

    protected async Task<bool> LoadSubscribedUser()
    {
        try
        {
            string sql = "select * from users join subscriptions on users.UserID = subscriptions.UserID where Email = @Email";
            SubscribedUser = await _data.QuerySingle<UserModel, dynamic>(sql, new { Email = this.queryStringEmail }, _config.GetConnectionString("default"));

            return await Task.FromResult(true);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);

            return await Task.FromResult(true);
        }
    }

    private async Task<bool> ValidateUser()
    {
        await LoadUsers();

        try
        {
            Dictionary<string, string> user_input = new Dictionary<string, string>();
            user_input.Add(User.City, User.PostalCode);

            // Gera ein ella annan logikk til at sanngilda b??r/bygdir og postnummur

            //var matches = FirstDictionary.Keys.Intersect(SecondDictionary.Keys);

            if (Users != null && Users.Count > 0)
            {
                if (!Users.Exists(x => x.CompanyName.Equals(User.CompanyName)) || Users.Exists(x => x.CompanyName.Equals("-")))
                {
                    if (!Users.Exists(x => x.Email.Equals(User.Email)))
                    {
                        if (this.customerBtn == "active")
                        {
                            await InsertCustomer();
                            await SaveAddress();

                            string name = User.FirstName + " " + User.LastName;

                            var url = "/";

                            await AuthenticateUser(name, User.Role, User.Email, url);
                        }
                        else
                        {
                            await InsertCompany();
                            await CreateSubscription();
                        }
                    }
                    else
                    {
                        this.companyErrMsg = "display: none;";
                        this.emailErrMsg = "display: initial;";
                    }
                }
                else
                {
                    this.emailErrMsg = "display: none;";
                    this.companyErrMsg = "display: initial;";
                }
            }
            else
            {
                if (this.customerBtn == "active")
                {
                    await InsertCustomer();
                    await SaveAddress();

                    string name = User.FirstName + " " + User.LastName;

                    var url = "/";

                    await AuthenticateUser(name, User.Role, User.Email, url);
                }
                else
                {
                    await InsertCompany();
                    await CreateSubscription();
                }
            }

            return await Task.FromResult(true);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);

            return await Task.FromResult(false);
        }
    }

    private async Task<bool> CreateSubscription()
    {
        try
        {
            string subFee = this.subscriptionFee + "00";

            string orderNumber = QuickPayConfig.GenerateOrderNumber();

            Dictionary<string, string> CreateSubscriptionVariables = new Dictionary<string, string>();
            Subscription subscription = null;

            CreateSubscriptionVariables.Add("address", User.Address);
            CreateSubscriptionVariables.Add("city", User.City);
            CreateSubscriptionVariables.Add("postal_code", User.PostalCode);
            CreateSubscriptionVariables.Add("email", User.Email);
            CreateSubscriptionVariables.Add("username", User.CompanyName);
            subscription = await QuickPayClient.Subscriptions.Create(
                orderNumber, "dkk", "Subscription", User.CompanyName, CreateSubscriptionVariables);

            PaymentLinkUrl subscriptionLink = await QuickPayClient.Subscriptions.CreateOrUpdatePaymentLink(
                subscription.Id, Int32.Parse(subFee), true, "en", "", QuickPayConfig.URL + "/stovna_brukara?em=" + User.Email,
                QuickPayConfig.URL + "/stovna_brukara?em=" + User.Email, QuickPayConfig.CALLBACKURL, true);

            if (subscriptionLink == null)
            {
                await DeleteUser(User.Email);

                NavigationManager.NavigateTo("stovna_brukara?em=" + User.Email);
            }
            else
            {
                NavigationManager.NavigateTo(subscriptionLink.Url);
            }

            return await Task.FromResult(true);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);

            return await Task.FromResult(false);
        }
    }

    private async Task<bool> InsertCustomer()
    {
        try
        {
            byte[] salt = ((ITreydAuthenticationStateProvider)AuthenticationStateProvider).GetSalt();

            string passwordHash = ((ITreydAuthenticationStateProvider)AuthenticationStateProvider).HashPassword(User.Password, salt);

            string passwordSalt = Convert.ToBase64String(salt);

            string sql = "insert into users (CompanyName, FirstName, LastName, Password, PasswordSalt, Email, Role, Updated, Registered)" +
                    "values (@CompanyName, @FirstName, @LastName, @Password, @PasswordSalt, @Email, @Role, @Updated, @Registered);";

            await _data.SaveData(sql, new
            {
                CompanyName = "-",
                FirstName = User.FirstName,
                LastName = User.LastName,
                Password = passwordHash,
                PasswordSalt = passwordSalt,
                Email = User.Email,
                Role = User.Role,
                Updated = DateTime.Now,
                Registered = DateTime.Now
            }, _config.GetConnectionString("default"));

            return await Task.FromResult(true);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);

            return await Task.FromResult(false);
        }
    }

    private async Task<bool> InsertCompany()
    {
        try
        {
            byte[] salt = ((ITreydAuthenticationStateProvider)AuthenticationStateProvider).GetSalt();

            string passwordHash = ((ITreydAuthenticationStateProvider)AuthenticationStateProvider)
                .HashPassword(User.Password, salt);

            string passwordSalt = Convert.ToBase64String(salt);

            string sql = "insert into users (CompanyName, FirstName, LastName, Password, PasswordSalt, Email, Role, Updated, Registered)" +
                    "values (@CompanyName, @FirstName, @LastName, @Password, @PasswordSalt, @Email, @Role, @Updated, @Registered);";

            await _data.SaveData(sql, new
            {
                CompanyName = User.CompanyName,
                FirstName = User.FirstName,
                LastName = User.LastName,
                Password = passwordHash,
                PasswordSalt = passwordSalt,
                Email = User.Email,
                Role = User.Role,
                Updated = DateTime.Now,
                Registered = DateTime.Now
            }, _config.GetConnectionString("default"));

            return await Task.FromResult(true);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);

            return await Task.FromResult(false);
        }
    }

    protected async Task<bool> VerifySubscription()
    {
        await LoadSubscribedUser();

        if (SubscribedUser != null)
        {
            try
            {
                var url = "/brukari/styripultur";

                await AuthenticateUser(SubscribedUser.CompanyName, SubscribedUser.Role, this.queryStringEmail, url);

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
            if (this.queryStringEmail != null && this.queryStringEmail != "")
            {
                await DeleteUser(this.queryStringEmail);

                this.displayAlert = true;
            }

            return await Task.FromResult(true);
        }
    }

    private async Task<bool> SaveAddress()
    {
        await LoadUser();

        try
        {
            string sql = "insert into addresses (Address, City, PostalCode, UserID, Registered)" +
                "values (@Address, @City, @PostalCode, @UserID, @Registered);";

            await _data.SaveData(sql, new
            {
                Address = User.Address,
                City = User.City,
                PostalCode = User.PostalCode,
                UserID = NewCustomer.UserID,
                Registered = DateTime.Now
            }
            , _config.GetConnectionString("default"));

            return await Task.FromResult(true);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);

            await DeleteUser(User.Email);

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

    protected async Task<bool> AuthenticateUser(string name, string role, string email, string url)
    {
        try
        {
            Auth = new AuthModel
            {
                Name = name,
                Role = role,
                Email = email
            };

            ((ITreydAuthenticationStateProvider)AuthenticationStateProvider).SetAuthenticationState(Auth);

            StateContainer.SetIsLoggedOut(false);
            StateContainer.SetIsRegistered(true);

            NavigationManager.NavigateTo(url);

            await SessionStorage.SetAsync("user", Auth);

            return await Task.FromResult(true);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);

            return await Task.FromResult(false);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private StateContainer StateContainer { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedSessionStorage SessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataAccess _data { get; set; }
    }
}
#pragma warning restore 1591
