#pragma checksum "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminDashboard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56becda51bc54a543ebdd8fbf090fc76eeed5700"
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
    public partial class AdminDashboard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "div");
                __builder2.AddAttribute(3, "class", "row");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "col-xs-12 col-sm-12 col-md-6 col-lg-6 col-xl-4 mt-4");
                __builder2.OpenComponent<treyd.Components.CustomCard>(6);
                __builder2.AddAttribute(7, "CardLink", "/brukari/voeruumsiting");
                __builder2.AddAttribute(8, "IconClass", "fas fa-warehouse");
                __builder2.AddAttribute(9, "CardTitle", "Vøruumsiting");
                __builder2.AddAttribute(10, "CardTextColor", "text-info");
                __builder2.AddAttribute(11, "CardBgColor", "bg-light");
                __builder2.AddAttribute(12, "FooterText", "");
                __builder2.AddAttribute(13, "FooterColor", "bg-info");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "col-xs-12 col-sm-12 col-md-6 col-lg-6 col-xl-4 mt-4");
                __builder2.OpenComponent<treyd.Components.CustomCard>(17);
                __builder2.AddAttribute(18, "CardLink", "/brukari/handil");
                __builder2.AddAttribute(19, "IconClass", "fas fa-store");
                __builder2.AddAttribute(20, "CardTitle", "Handil");
                __builder2.AddAttribute(21, "CardTextColor", "text-info");
                __builder2.AddAttribute(22, "CardBgColor", "bg-light");
                __builder2.AddAttribute(23, "FooterText", "");
                __builder2.AddAttribute(24, "FooterColor", "bg-secondary");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n            ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "col-xs-12 col-sm-12 col-md-12 col-lg-12 col-xl-4 mt-4");
                __builder2.OpenComponent<treyd.Components.CustomCard>(28);
                __builder2.AddAttribute(29, "CardLink", "/brukari/bileggingar");
                __builder2.AddAttribute(30, "IconClass", "fas fa-boxes");
                __builder2.AddAttribute(31, "CardTitle", "Bíleggingar");
                __builder2.AddAttribute(32, "CardTextColor", "text-info");
                __builder2.AddAttribute(33, "CardBgColor", "bg-light");
                __builder2.AddAttribute(34, "FooterText", "");
                __builder2.AddAttribute(35, "FooterColor", "bg-success");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n            ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "col-xs-12 col-sm-12 col-md-6 col-lg-6 col-xl-4 mt-4");
                __builder2.OpenComponent<treyd.Components.CustomCard>(39);
                __builder2.AddAttribute(40, "CardLink", "/brukari/gjaldingar");
                __builder2.AddAttribute(41, "IconClass", "fas fa-money-check");
                __builder2.AddAttribute(42, "CardTitle", "Gjaldingar");
                __builder2.AddAttribute(43, "CardTextColor", "text-info");
                __builder2.AddAttribute(44, "CardBgColor", "bg-light");
                __builder2.AddAttribute(45, "FooterText", "");
                __builder2.AddAttribute(46, "FooterColor", "bg-warning");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n            ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "col-xs-12 col-sm-12 col-md-6 col-lg-6 col-xl-4 mt-4");
                __builder2.OpenComponent<treyd.Components.CustomCard>(50);
                __builder2.AddAttribute(51, "CardLink", "/brukari/aetlan");
                __builder2.AddAttribute(52, "IconClass", "fas fa-calendar-day");
                __builder2.AddAttribute(53, "CardTitle", "Ætlan");
                __builder2.AddAttribute(54, "CardTextColor", "text-info");
                __builder2.AddAttribute(55, "CardBgColor", "bg-light");
                __builder2.AddAttribute(56, "FooterText", "");
                __builder2.AddAttribute(57, "FooterColor", "bg-dark");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n            ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "col-xs-12 col-sm-12 col-md-12 col-lg-12 col-xl-4 mt-4");
                __builder2.OpenComponent<treyd.Components.CustomCard>(61);
                __builder2.AddAttribute(62, "CardLink", "/brukari/hagtoel");
                __builder2.AddAttribute(63, "IconClass", "fas fa-chart-area");
                __builder2.AddAttribute(64, "CardTitle", "Hagtøl");
                __builder2.AddAttribute(65, "CardTextColor", "text-info");
                __builder2.AddAttribute(66, "CardBgColor", "bg-light");
                __builder2.AddAttribute(67, "FooterText", "");
                __builder2.AddAttribute(68, "FooterColor", "bg-primary");
                __builder2.CloseComponent();
                __builder2.CloseElement();
#nullable restore
#line 60 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminDashboard.razor"
             if (context.User.IsInRole("Admin"))
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "col-xs-12 col-sm-12 col-md-12 col-lg-12 col-xl-4 mt-4");
                __builder2.OpenComponent<treyd.Components.CustomCard>(71);
                __builder2.AddAttribute(72, "CardLink", "/brukari/brukarar");
                __builder2.AddAttribute(73, "IconClass", "fas fa-users");
                __builder2.AddAttribute(74, "CardTitle", "Brúkarar");
                __builder2.AddAttribute(75, "CardTextColor", "text-info");
                __builder2.AddAttribute(76, "CardBgColor", "bg-light");
                __builder2.AddAttribute(77, "FooterText", "");
                __builder2.AddAttribute(78, "FooterColor", "bg-danger");
                __builder2.CloseComponent();
                __builder2.CloseElement();
#nullable restore
#line 71 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminDashboard.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(79, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenComponent<treyd.Components.Redirects.LoginRedirect>(80);
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591