// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace treyd.Components.Admin
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
#line 1 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminProfile.razor"
using DataLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminProfile.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminProfile.razor"
using Microsoft.AspNetCore.WebUtilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminProfile.razor"
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminProfile.razor"
using QuickPay.SDK;

#line default
#line hidden
#nullable disable
    public partial class AdminProfile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 298 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminProfile.razor"
       
    private QuickPayClient QuickPayClient = new QuickPayClient(QuickPayConfig.API_KEY, QuickPayConfig.PRIVATE_KEY, QuickPayConfig.USER);

    private AuthModel Auth { get; set; }

    private UserModel User { get; set; } = new UserModel();
    private AddressModel Address { get; set; } = new AddressModel();
    private PasswordModel Password { get; set; } = new PasswordModel();
    private SubscriptionModel SubscriptionModel { get; set; }

    private List<UserModel> Users;

    private string email = "";

    private string emailErrMsg = "display: none;";
    //private string companyErrMsg = "display: none;";
    private string passwordErrMsg = "display: none;";

    private bool uEnabled = false;
    private bool aEnabled = false;
    private bool pEnabled = false;

    private bool editUser = false;
    private bool editAddress = false;
    private bool changePassword = false;

    private bool displayUserSuccessAlert = false;
    private bool displayUserDangerAlert = false;
    private bool displayAddressSuccessAlert = false;
    private bool displayAddressDangerAlert = false;
    private bool displayPasswordSuccessAlert = false;
    private bool displayPasswordDangerAlert = false;

    protected override async Task OnInitializedAsync()
    {
        if (await ((TreydAuthenticationStateProvider)AuthenticationStateProvider).GetAuthenticationStateAsync() is not null)
        {
            var result = await SessionStorage.GetAsync<AuthModel>("user");
            Auth = result.Success ? result.Value : null;

            this.email = Auth.Email;
            
            await LoadUser();
            await LoadAddress();
        }
    }

    protected void Reset()
    {
        this.uEnabled = false;
        this.aEnabled = false;
        this.pEnabled = false;

        this.editUser = false;
        this.editAddress = false;
        this.changePassword = false;

        this.emailErrMsg = "display: none;";
        //this.companyErrMsg = "display: none;";
        this.passwordErrMsg = "display: none;";
    }

    public void EditUser()
    {
        this.editUser = true;
        this.editAddress = false;
        this.changePassword = false;

        this.uEnabled = true;
        this.aEnabled = false;
        this.pEnabled = false;

        this.displayUserSuccessAlert = false;
        this.displayUserDangerAlert = false;
        this.displayAddressSuccessAlert = false;
        this.displayAddressDangerAlert = false;
        this.displayPasswordSuccessAlert = false;
        this.displayPasswordDangerAlert = false;

        this.emailErrMsg = "display: none;";
        //this.companyErrMsg = "display: none;";
        this.passwordErrMsg = "display: none;";
    }

    public void EditAddress()
    {
        this.editAddress = true;
        this.editUser = false;
        this.changePassword = false;

        this.aEnabled = true;
        this.uEnabled = false;
        this.pEnabled = false;

        this.displayUserSuccessAlert = false;
        this.displayUserDangerAlert = false;
        this.displayAddressSuccessAlert = false;
        this.displayAddressDangerAlert = false;
        this.displayPasswordSuccessAlert = false;
        this.displayPasswordDangerAlert = false;

        this.emailErrMsg = "display: none;";
        //this.companyErrMsg = "display: none;";
        this.passwordErrMsg = "display: none;";
    }

    public void ChangePassword()
    {
        this.changePassword = true;
        this.editUser = false;
        this.editAddress = false;

        this.pEnabled = true;
        this.uEnabled = false;
        this.aEnabled = false;

        this.displayUserSuccessAlert = false;
        this.displayUserDangerAlert = false;
        this.displayAddressSuccessAlert = false;
        this.displayAddressDangerAlert = false;
        this.displayPasswordSuccessAlert = false;
        this.displayPasswordDangerAlert = false;

        this.emailErrMsg = "display: none;";
        //this.companyErrMsg = "display: none;";
        this.passwordErrMsg = "display: none;";
    }

    protected async Task<bool> LoadUser()
    {
        try
        {
            string sql = "select * from users where Email = @Email";
            User = await _data.QuerySingle<UserModel, dynamic>(sql, new { Email = Auth.Email }, _config.GetConnectionString("default"));

            User.ConfirmPassword = User.Password;

            return await Task.FromResult(true);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);

            return await Task.FromResult(false);
        }
    }

    protected async Task<bool> LoadAddress()
    {
        try
        {
            string sql = "select * from addresses where UserID = @UserID";
            Address = await _data.QuerySingle<AddressModel, dynamic>(sql, new { UserID = User.UserID }, _config.GetConnectionString("default"));

            Address.User = User;

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

    protected async Task<bool> LoadCurrentSubscription()
    {
        try
        {
            string sql = "select * from subscriptions join users on subscriptions.UserID = users.UserID where Email = @Email";
            SubscriptionModel = await _data.QuerySingle<SubscriptionModel, dynamic>(sql, new { Email = Auth.Email }, _config.GetConnectionString("default"));

            return await Task.FromResult(true);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);

            return await Task.FromResult(false);
        }
    }

    private async Task<bool> ValidateUser()
    {
        await LoadUsers();

        if (Users != null && Users.Count > 0 && User != null)
        {
            if (Users.Exists(x => !(x.Email.Equals(User.Email)) || x.Email.Equals(User.Email) && x.UserID.Equals(User.UserID)))
            {
                if (User.Role.Equals("Company") || User.Role.Equals("Admin"))
                {
                    await UpdateCompany();
                }
                else
                {
                    await UpdateCustomer();
                }

                Reset();

                displayUserDangerAlert = false;
                displayUserSuccessAlert = true;

                return await Task.FromResult(true);
            }
            else
            {
                this.emailErrMsg = "display: initial;";

                return await Task.FromResult(false);
            }
        }
        else
        {
            displayUserSuccessAlert = false;
            displayUserDangerAlert = true;

            return await Task.FromResult(false);
        }
    }

    private async Task<bool> ValidateAddress()
    {
        if (Address != null)
        {
            await UpdateAddress();
            Reset();

            this.displayAddressDangerAlert = false;
            this.displayAddressSuccessAlert = true;

            return await Task.FromResult(true);
        }

        this.displayAddressSuccessAlert = false;
        this.displayAddressDangerAlert = true;

        return await Task.FromResult(false);
    }

    private async Task<bool> ValidatePassword()
    {
        if (User != null)
        {
            byte[] salt = Convert.FromBase64String(User.PasswordSalt);

            string passwordHash = ((TreydAuthenticationStateProvider)AuthenticationStateProvider).HashPassword(Password.CurrentPassword, salt);

            if (User.Password == passwordHash)
            {
                await UpdatePassword();
                Reset();

                this.passwordErrMsg = "display: none;";
                this.displayPasswordDangerAlert = false;
                this.displayPasswordSuccessAlert = true;

                return await Task.FromResult(true);
            }
            else
            {
                this.passwordErrMsg = "display: initial;";

                return await Task.FromResult(false);
            }
        }
        else
        {
            this.displayPasswordSuccessAlert = false;
            this.displayPasswordDangerAlert = true;

            return await Task.FromResult(false);
        }
    }

    private async Task<bool> UpdateCustomer()
    {
        try
        {
            string sql = "update users set FirstName = @FirstName, LastName = @LastName, " +
                    "Email = @Email, Updated = @Updated where UserID = @UserID";

            await _data.SaveData(sql, new
            {
                UserID = User.UserID,
                FirstName = User.FirstName,
                LastName = User.LastName,
                Email = User.Email,
                Updated = DateTime.Now
            }, _config.GetConnectionString("default"));

            string name = User.FirstName + " " + User.LastName;

            var url = "/";

            await AuthenticateUser(name, User.Role, User.Email);

            return await Task.FromResult(true);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);

            return await Task.FromResult(false);
        }
    }

    private async Task<bool> UpdateCompany()
    {
        try
        {
            string sql = "update users set FirstName = @FirstName, LastName = @LastName, " +
                    "Email = @Email, Updated = @Updated where UserID = @UserID";

            await _data.SaveData(sql, new
            {
                UserID = User.UserID,
                FirstName = User.FirstName,
                LastName = User.LastName,
                Email = User.Email,
                Updated = DateTime.Now
            }, _config.GetConnectionString("default"));

            var url = "/brukari/styripultur";

            await AuthenticateUser(User.CompanyName, User.Role, User.Email);

            return await Task.FromResult(true);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);

            return await Task.FromResult(false);
        }
    }

    private async Task<bool> UpdateAddress()
    {
        try
        {
            string sql = "update addresses set Address = @Address, City = @City, PostalCode = @PostalCode, " +
                    "Updated = @Updated, where AddressID = @AddressID";

            await _data.SaveData(sql, new
            {
                AddressID = Address.AddressID,
                Address = Address.Address,
                City = Address.City,
                PostalCode = Address.PostalCode,
                Updated = DateTime.Now
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

    private async Task<bool> UpdatePassword()
    {
        try
        {
            byte[] salt = ((ITreydAuthenticationStateProvider)AuthenticationStateProvider).GetSalt();

            string passwordHash = ((ITreydAuthenticationStateProvider)AuthenticationStateProvider).HashPassword(Password.NewPassword, salt);

            string passwordSalt = Convert.ToBase64String(salt);

            string sql = "update users set Password = @Password, PasswordSalt = @PasswordSalt, Updated = @Updated where UserID = @UserID";

            await _data.SaveData(sql, new
            {
                UserID = User.UserID,
                Password = passwordHash,
                PasswordSalt = passwordSalt,
                Updated = DateTime.Now
            }, _config.GetConnectionString("default"));

            return await Task.FromResult(true);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);

            return await Task.FromResult(false);
        }
    }

    private async Task CancelSubscription()
    {
        if (SubscriptionModel.Status != "Cancelled")
        {
            try
            {
                await QuickPayClient.Subscriptions.Cancel(SubscriptionModel.SubscriptionNumber);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }

    protected async Task<bool> DeleteUser()
    {
        try
        {
            await CancelSubscription();

            string sql = "delete from users where Email = @Email";

            await _data.SaveData(sql, new { Email = User.Email }, _config.GetConnectionString("default"));

            StateContainer.SetIsLoggedIn(false);
            StateContainer.SetIsRegistered(false);
            StateContainer.SetIsLoggedOut(false);
            StateContainer.SetIsDeleted(true);

            NavigationManager.NavigateTo("/");

            ((TreydAuthenticationStateProvider)AuthenticationStateProvider).UnsetAuthenticationState();

            return await Task.FromResult(true);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);

            return await Task.FromResult(false);
        }
    }

    protected async Task<bool> AuthenticateUser(string name, string role, string email)
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