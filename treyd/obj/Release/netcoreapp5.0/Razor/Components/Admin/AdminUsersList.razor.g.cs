#pragma checksum "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminUsersList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4f52b031162cce14df6f82c1c8b4b2828342148"
// <auto-generated/>
#pragma warning disable 1591
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
#line 11 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\_Imports.razor"
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

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
#line 1 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminUsersList.razor"
using DataLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminUsersList.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    public partial class AdminUsersList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-xs-12 col-sm-12 col-md-12 col-lg-12 col-xl-6");
            __builder.AddAttribute(2, "style", "height: 292px;");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card mb-3");
            __builder.AddMarkupContent(5, "<div class=\"card-header\"><i class=\"fa fa-user\"></i> Kundar\r\n        </div>\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "category-wrapper card-body");
            __builder.AddAttribute(8, "style", "height: 211.33px;");
            __builder.OpenElement(9, "table");
            __builder.AddAttribute(10, "class", "table table-bordered");
            __builder.AddAttribute(11, "id", "dataTable");
            __builder.AddAttribute(12, "width", "100%");
            __builder.AddAttribute(13, "cellspacing", "0");
            __builder.AddMarkupContent(14, "<thead><tr><th>ID</th>\r\n                        <th>Navn</th>\r\n                        <th>Teldupostur</th></tr></thead>\r\n                ");
            __builder.AddMarkupContent(15, "<tfoot><tr><th>ID</th>\r\n                        <th>Navn</th>\r\n                        <th>Teldupostur</th></tr></tfoot>\r\n                ");
            __builder.OpenElement(16, "tbody");
#nullable restore
#line 29 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminUsersList.razor"
                     foreach (var user in Users)
                    {
                        if (user.Role == this.CustomerRole)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "tr");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 34 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminUsersList.razor"
                                     user.UserID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                                ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 35 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminUsersList.razor"
                                     user.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(23, " ");
            __builder.AddContent(24, 
#nullable restore
#line 35 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminUsersList.razor"
                                                     user.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                                ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 36 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminUsersList.razor"
                                     user.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 38 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminUsersList.razor"
                        }
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.AddMarkupContent(29, "<div class=\"card-footer small text-muted\">Updated yesterday at 11:59 PM</div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\r\n");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "col-xs-12 col-sm-12 col-md-12 col-lg-12 col-xl-6");
            __builder.AddAttribute(33, "style", "height: 292px;");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "card mb-3");
            __builder.AddMarkupContent(36, "<div class=\"card-header\"><i class=\"fa fa-users\"></i> Fyritøkur\r\n        </div>\r\n        ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "category-wrapper card-body");
            __builder.AddAttribute(39, "style", "height: 211.33px;");
            __builder.OpenElement(40, "table");
            __builder.AddAttribute(41, "class", "table table-bordered");
            __builder.AddAttribute(42, "id", "dataTable");
            __builder.AddAttribute(43, "width", "100%");
            __builder.AddAttribute(44, "cellspacing", "0");
            __builder.AddMarkupContent(45, "<thead><tr><th>ID</th>\r\n                        <th>Navn</th>\r\n                        <th>Ábyrgd</th>\r\n                        <th>Teldupostur</th></tr></thead>\r\n                ");
            __builder.AddMarkupContent(46, "<tfoot><tr><th>ID</th>\r\n                        <th>Navn</th>\r\n                        <th>Ábyrgd</th>\r\n                        <th>Teldupostur</th></tr></tfoot>\r\n                ");
            __builder.OpenElement(47, "tbody");
#nullable restore
#line 71 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminUsersList.razor"
                     foreach (var user in Users)
                    {
                        if (user.Role == this.CompanyRole)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(48, "tr");
            __builder.OpenElement(49, "td");
            __builder.AddContent(50, 
#nullable restore
#line 76 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminUsersList.razor"
                                     user.UserID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                                ");
            __builder.OpenElement(52, "td");
            __builder.AddContent(53, 
#nullable restore
#line 77 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminUsersList.razor"
                                     user.CompanyName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                                ");
            __builder.OpenElement(55, "td");
            __builder.AddContent(56, 
#nullable restore
#line 78 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminUsersList.razor"
                                     user.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(57, " ");
            __builder.AddContent(58, 
#nullable restore
#line 78 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminUsersList.razor"
                                                     user.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                                ");
            __builder.OpenElement(60, "td");
            __builder.AddContent(61, 
#nullable restore
#line 79 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminUsersList.razor"
                                     user.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 81 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminUsersList.razor"
                        }
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n        ");
            __builder.AddMarkupContent(63, "<div class=\"card-footer small text-muted\">Updated yesterday at 11:59 PM</div>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 90 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminUsersList.razor"
       
    [Parameter] public string CustomerRole { get; set; }
    [Parameter] public string CompanyRole { get; set; }

    private List<UserModel> Users;

    protected override async Task OnInitializedAsync()
    {
        await LoadUsers();
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

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataAccess _data { get; set; }
    }
}
#pragma warning restore 1591