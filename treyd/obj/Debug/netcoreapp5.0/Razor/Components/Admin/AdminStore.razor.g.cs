#pragma checksum "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminStore.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f3eb92bba3d908bf74cdcf345fe9b76c5954a83"
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
#line 1 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminStore.razor"
using DataLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminStore.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    public partial class AdminStore : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal-backdrop");
            __builder.AddAttribute(2, "style", 
#nullable restore
#line 8 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminStore.razor"
                                    modalBackdropDisplay

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(3, "b-ph6jbmum5d");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminStore.razor"
                  StoreModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminStore.razor"
                                              ValidateStore

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "container-fluid p-0");
                __builder2.AddAttribute(11, "b-ph6jbmum5d");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "container-fluid p-0 overflow-hidden");
                __builder2.AddAttribute(14, "style", "background-color:" + " " + (
#nullable restore
#line 12 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminStore.razor"
                                                                                   mainColor

#line default
#line hidden
#nullable disable
                ) + ";" + " height:" + " 40vh;");
                __builder2.AddAttribute(15, "b-ph6jbmum5d");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "container align-items-center");
                __builder2.AddAttribute(18, "style", "width:" + " 100%;" + " height:" + " 100%;" + " background:" + " url(" + (
#nullable restore
#line 13 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminStore.razor"
                                                                                                         coverImagePath

#line default
#line hidden
#nullable disable
                ) + ");" + " background-position:" + " 50%" + " 50%;" + " background-size:" + " cover;");
                __builder2.AddAttribute(19, "b-ph6jbmum5d");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "w-100 h-100");
                __builder2.AddAttribute(22, "b-ph6jbmum5d");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "modal fade");
                __builder2.AddAttribute(25, "id", "exampleModal");
                __builder2.AddAttribute(26, "tabindex", "-1");
                __builder2.AddAttribute(27, "aria-labelledby", "exampleModalLabel");
                __builder2.AddAttribute(28, "aria-hidden", "true");
                __builder2.AddAttribute(29, "b-ph6jbmum5d");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "modal-dialog");
                __builder2.AddAttribute(32, "b-ph6jbmum5d");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "modal-content");
                __builder2.AddAttribute(35, "b-ph6jbmum5d");
                __builder2.AddMarkupContent(36, @"<div class=""modal-header"" b-ph6jbmum5d><h5 class=""modal-title"" id=""exampleModalLabel"" b-ph6jbmum5d>Set permumynd</h5>
                                    <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close"" b-ph6jbmum5d></button></div>
                                ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "modal-body");
                __builder2.AddAttribute(39, "b-ph6jbmum5d");
                __builder2.OpenComponent<Syncfusion.Blazor.Inputs.SfTextBox>(40);
                __builder2.AddAttribute(41, "CssClass", "e-outline");
                __builder2.AddAttribute(42, "Placeholder", "Leinki til permumynd");
                __builder2.AddAttribute(43, "FloatLabelType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Inputs.FloatLabelType>(
#nullable restore
#line 24 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminStore.razor"
                                                                                                                        FloatLabelType.Auto

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminStore.razor"
                                                                                                                                                           StoreModel.CoverImagePath

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(45, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => StoreModel.CoverImagePath = __value, StoreModel.CoverImagePath))));
                __builder2.AddAttribute(46, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => StoreModel.CoverImagePath));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n                                ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "modal-footer");
                __builder2.AddAttribute(50, "b-ph6jbmum5d");
                __builder2.AddMarkupContent(51, "<button type=\"button\" class=\"btn btn-secondary\" data-bs-dismiss=\"modal\" b-ph6jbmum5d>Lat aftur</button>\r\n                                    ");
                __builder2.OpenElement(52, "button");
                __builder2.AddAttribute(53, "type", "button");
                __builder2.AddAttribute(54, "class", "btn btn-success");
                __builder2.AddAttribute(55, "data-bs-dismiss", "modal");
                __builder2.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminStore.razor"
                                                                                                                    SetCoverImage

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(57, "b-ph6jbmum5d");
                __builder2.AddContent(58, "Goym");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n        ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "container");
                __builder2.AddAttribute(62, "style", "margin: -100px auto 20px auto; padding: 0 50px; border-radius: 20px; height: 250px;");
                __builder2.AddAttribute(63, "b-ph6jbmum5d");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "container");
                __builder2.AddAttribute(66, "style", "background-color: white; margin: 0 auto 0 auto; box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19); border-radius: 20px; height: 100%;");
                __builder2.AddAttribute(67, "b-ph6jbmum5d");
                __builder2.OpenElement(68, "div");
                __builder2.AddAttribute(69, "class", "h-100 row align-items-center justify-content-center");
                __builder2.AddAttribute(70, "b-ph6jbmum5d");
                __builder2.AddMarkupContent(71, "<div class=\"h-100 col position-relative\" b-ph6jbmum5d></div>\r\n                    ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "h-100 col text-center position-relative");
                __builder2.AddAttribute(74, "b-ph6jbmum5d");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "row justify-content-center text-info");
                __builder2.AddAttribute(77, "style", "margin-top: 120px; font-size: 30px;");
                __builder2.AddAttribute(78, "b-ph6jbmum5d");
                __builder2.OpenElement(79, "strong");
                __builder2.AddAttribute(80, "b-ph6jbmum5d");
                __builder2.AddContent(81, 
#nullable restore
#line 45 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminStore.razor"
                                     Seller

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n                    <div class=\"h-100 col position-relative\" b-ph6jbmum5d></div>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n                ");
                __builder2.OpenElement(84, "div");
                __builder2.AddAttribute(85, "class", "align-items-center overflow-hidden");
                __builder2.AddAttribute(86, "style", "width:" + " 200px;" + " height:" + " 200px;" + " background:" + " url(" + (
#nullable restore
#line 52 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminStore.razor"
                                                                                                                     storeIconPath

#line default
#line hidden
#nullable disable
                ) + ");" + " box-shadow:" + " 0" + " 4px" + " 8px" + " 0" + " rgba(0," + " 0," + " 0," + " 0.2)," + " 0" + " 6px" + " 20px" + " 0" + " rgba(0," + " 0," + " 0," + " 0.19);" + " background-position:" + " 50%" + " 50%;" + " background-size:" + " cover;" + " margin:" + " -350px" + " auto" + " 0" + " auto;" + " background-color:" + " white;" + " border:" + " 4px" + " solid" + " " + (
#nullable restore
#line 52 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminStore.razor"
                                                                                                                                                                                                                                                                                                                                                 mainColor

#line default
#line hidden
#nullable disable
                ) + ";" + " border-radius:" + " 50%;");
                __builder2.AddAttribute(87, "b-ph6jbmum5d");
                __builder2.OpenElement(88, "div");
                __builder2.AddAttribute(89, "class", "modal fade");
                __builder2.AddAttribute(90, "id", "exampleModal1");
                __builder2.AddAttribute(91, "tabindex", "-1");
                __builder2.AddAttribute(92, "aria-labelledby", "exampleModalLabel1");
                __builder2.AddAttribute(93, "aria-hidden", "true");
                __builder2.AddAttribute(94, "b-ph6jbmum5d");
                __builder2.OpenElement(95, "div");
                __builder2.AddAttribute(96, "class", "modal-dialog");
                __builder2.AddAttribute(97, "b-ph6jbmum5d");
                __builder2.OpenElement(98, "div");
                __builder2.AddAttribute(99, "class", "modal-content");
                __builder2.AddAttribute(100, "b-ph6jbmum5d");
                __builder2.AddMarkupContent(101, @"<div class=""modal-header"" b-ph6jbmum5d><h5 class=""modal-title"" id=""exampleModalLabel1"" b-ph6jbmum5d>Set b??merki</h5>
                                    <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close"" b-ph6jbmum5d></button></div>
                                ");
                __builder2.OpenElement(102, "div");
                __builder2.AddAttribute(103, "class", "modal-body");
                __builder2.AddAttribute(104, "b-ph6jbmum5d");
                __builder2.OpenComponent<Syncfusion.Blazor.Inputs.SfTextBox>(105);
                __builder2.AddAttribute(106, "CssClass", "e-outline");
                __builder2.AddAttribute(107, "Placeholder", "Leinki til b??merki");
                __builder2.AddAttribute(108, "FloatLabelType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Inputs.FloatLabelType>(
#nullable restore
#line 62 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminStore.razor"
                                                                                                                      FloatLabelType.Auto

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(109, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 62 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminStore.razor"
                                                                                                                                                         StoreModel.StoreIconPath

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(110, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => StoreModel.StoreIconPath = __value, StoreModel.StoreIconPath))));
                __builder2.AddAttribute(111, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => StoreModel.StoreIconPath));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(112, "\r\n                                ");
                __builder2.OpenElement(113, "div");
                __builder2.AddAttribute(114, "class", "modal-footer");
                __builder2.AddAttribute(115, "b-ph6jbmum5d");
                __builder2.AddMarkupContent(116, "<button type=\"button\" class=\"btn btn-secondary\" data-bs-dismiss=\"modal\" b-ph6jbmum5d>Lat aftur</button>\r\n                                    ");
                __builder2.OpenElement(117, "button");
                __builder2.AddAttribute(118, "type", "button");
                __builder2.AddAttribute(119, "class", "btn btn-success");
                __builder2.AddAttribute(120, "data-bs-dismiss", "modal");
                __builder2.AddAttribute(121, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 67 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminStore.razor"
                                                                                                                    SetStoreIcon

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(122, "b-ph6jbmum5d");
                __builder2.AddContent(123, "Goym");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(124, "\r\n    ");
                __builder2.OpenElement(125, "div");
                __builder2.AddAttribute(126, "class", "container");
                __builder2.AddAttribute(127, "style", "background-color: white; padding-top: 30px; z-index: -1;");
                __builder2.AddAttribute(128, "b-ph6jbmum5d");
                __builder2.OpenElement(129, "div");
                __builder2.AddAttribute(130, "class", "row");
                __builder2.AddAttribute(131, "b-ph6jbmum5d");
                __builder2.AddMarkupContent(132, @"<nav b-ph6jbmum5d><div class=""nav nav-tabs flex-sm-row"" id=""nav-tab"" role=""tablist"" b-ph6jbmum5d><button class=""flex-sm-fill text-sm-center nav-link text-info active"" id=""nav-home-tab"" data-bs-toggle=""tab"" data-bs-target=""#nav-home"" type=""button"" role=""tab"" aria-controls=""nav-home"" aria-selected=""true"" b-ph6jbmum5d>V??rur</button>
                    <button class=""flex-sm-fill text-sm-center nav-link text-info"" id=""nav-profile-tab"" data-bs-toggle=""tab"" data-bs-target=""#nav-profile"" type=""button"" role=""tab"" aria-controls=""nav-profile"" aria-selected=""false"" b-ph6jbmum5d>V??rub??lkar</button></div></nav>
            ");
                __builder2.OpenElement(133, "div");
                __builder2.AddAttribute(134, "class", "tab-content");
                __builder2.AddAttribute(135, "id", "nav-tabContent");
                __builder2.AddAttribute(136, "b-ph6jbmum5d");
                __builder2.OpenElement(137, "div");
                __builder2.AddAttribute(138, "class", "tab-pane fade show active");
                __builder2.AddAttribute(139, "id", "nav-home");
                __builder2.AddAttribute(140, "role", "tabpanel");
                __builder2.AddAttribute(141, "aria-labelledby", "nav-home-tab");
                __builder2.AddAttribute(142, "b-ph6jbmum5d");
                __builder2.OpenElement(143, "div");
                __builder2.AddAttribute(144, "class", "flex-wrapper row wow fadeIn");
                __builder2.AddAttribute(145, "b-ph6jbmum5d");
#nullable restore
#line 87 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminStore.razor"
                         if (Products != null)
                        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(146, "div");
                __builder2.AddAttribute(147, "class", "prod");
                __builder2.AddAttribute(148, "b-ph6jbmum5d");
                __builder2.OpenElement(149, "div");
                __builder2.AddAttribute(150, "class", "row");
                __builder2.AddAttribute(151, "style", "text-align: center; justify-content: start");
                __builder2.AddAttribute(152, "b-ph6jbmum5d");
#nullable restore
#line 91 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminStore.razor"
                                     foreach (var product in Products)
                                    {
                                        if (product.Published == true)
                                        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(153, "div");
                __builder2.AddAttribute(154, "class", "col-xs-6 col-sm-6 col-md-6 col-lg-3 col-xl-3 mb-4");
                __builder2.AddAttribute(155, "b-ph6jbmum5d");
                __builder2.OpenComponent<treyd.Components.Product.Product>(156);
                __builder2.AddAttribute(157, "ProductModel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<treyd.Models.ProductModel>(
#nullable restore
#line 96 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminStore.razor"
                                                                       product

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(158, "GetBackdrop", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 96 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminStore.razor"
                                                                                              ToggleBackdrop

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(159, "ViewMode", "GridView");
                __builder2.CloseComponent();
                __builder2.CloseElement();
#nullable restore
#line 98 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminStore.razor"
                                        }
                                    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 102 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminStore.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(160, "\r\n                ");
                __builder2.AddMarkupContent(161, "<div class=\"tab-pane fade\" id=\"nav-profile\" role=\"tabpanel\" aria-labelledby=\"nav-profile-tab\" b-ph6jbmum5d>\r\n                    V??rub??lkar\r\n                </div>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(162, "\r\n\r\n    ");
                __builder2.OpenElement(163, "div");
                __builder2.AddAttribute(164, "class", "admin-store-toolbar");
                __builder2.AddAttribute(165, "b-ph6jbmum5d");
                __builder2.OpenElement(166, "div");
                __builder2.AddAttribute(167, "class", "h-100 d-table table-layout-fixed w-100");
                __builder2.AddAttribute(168, "b-ph6jbmum5d");
                __builder2.OpenElement(169, "div");
                __builder2.AddAttribute(170, "class", "h-100 d-table-cell text-center p-2");
                __builder2.AddAttribute(171, "b-ph6jbmum5d");
                __builder2.AddMarkupContent(172, "<div class=\"row\" b-ph6jbmum5d><label for=\"main-color\" class=\"form-label text-info\" b-ph6jbmum5d>H??vu??slitur</label></div>\r\n                ");
                __builder2.OpenElement(173, "div");
                __builder2.AddAttribute(174, "class", "row");
                __builder2.AddAttribute(175, "b-ph6jbmum5d");
                __builder2.OpenComponent<Syncfusion.Blazor.Inputs.SfColorPicker>(176);
                __builder2.AddAttribute(177, "id", "main-color");
                __builder2.AddAttribute(178, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 119 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminStore.razor"
                                                                mainColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(179, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => mainColor = __value, mainColor))));
                __builder2.AddAttribute(180, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => mainColor));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(181, "\r\n            ");
                __builder2.AddMarkupContent(182, @"<div class=""h-100 d-table-cell text-center p-2"" b-ph6jbmum5d><span class=""h-100 admin-store-toolbar-label"" b-ph6jbmum5d><button type=""button"" class=""w-100 h-100 btn btn-outline-info"" data-bs-toggle=""modal"" data-bs-target=""#exampleModal"" b-ph6jbmum5d>
                        Set permumynd
                    </button></span></div>
            ");
                __builder2.AddMarkupContent(183, @"<div class=""h-100 d-table-cell text-center p-2"" b-ph6jbmum5d><span class=""h-100 admin-store-toolbar-label"" b-ph6jbmum5d><button type=""button"" class=""w-100 h-100 btn btn-outline-info"" data-bs-toggle=""modal"" data-bs-target=""#exampleModal1"" b-ph6jbmum5d>
                        Set b??merki
                    </button></span></div>
            ");
                __builder2.OpenElement(184, "div");
                __builder2.AddAttribute(185, "class", "h-100 d-table-cell text-center p-2");
                __builder2.AddAttribute(186, "b-ph6jbmum5d");
                __builder2.OpenElement(187, "span");
                __builder2.AddAttribute(188, "class", "h-100 admin-store-toolbar-label");
                __builder2.AddAttribute(189, "b-ph6jbmum5d");
#nullable restore
#line 138 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminStore.razor"
                     if (StoreModel != null)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(190, "<button class=\"w-100 h-100 btn btn-outline-warning\" type=\"submit\" b-ph6jbmum5d>Dagf??r</button>");
#nullable restore
#line 141 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminStore.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(191, "<button class=\"w-100 h-100 btn btn-outline-success\" type=\"submit\" b-ph6jbmum5d>Goym</button>");
#nullable restore
#line 145 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminStore.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(192, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(193, "<style b-ph6jbmum5d>\r\n    .modal-backdrop {\r\n        opacity: 0.5;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 152 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\Admin\AdminStore.razor"
       
    [Parameter] public string Seller { get; set; }

    private StoreModel StoreModel { get; set; } = new StoreModel();

    private List<ProductModel> Products;

    private string mainColor = "#0e3976;";
    private string coverImagePath;
    private string storeIconPath;

    private bool exists = false;

    private string modalBackdropDisplay = "display: none;";

    protected override async Task OnInitializedAsync()
    {
        await LoadStore();
        await LoadProducts();
    }

    public void ToggleBackdrop(bool backdrop)
    {
        if (backdrop == true)
        {
            this.modalBackdropDisplay = "display: block;";
        }
        else if (backdrop == false)
        {
            this.modalBackdropDisplay = "display: none;";
        }
    }

    protected async Task<bool> LoadStore()
    {
        try
        {
            string sql = "select * from stores where Name = @Name";
            StoreModel = await _data.QuerySingle<StoreModel, dynamic>(sql, new { Name = this.Seller }, _config.GetConnectionString("default"));

            if (StoreModel != null)
            {
                this.exists = true;
                this.mainColor = StoreModel.MainColor;
                this.coverImagePath = StoreModel.CoverImagePath;
                this.storeIconPath = StoreModel.StoreIconPath;
            }

            return await Task.FromResult(true);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);

            return await Task.FromResult(false);
        }
    }

    protected async Task<bool> LoadProducts()
    {
        try
        {
            string sql1 = "select * from products where Seller = @Seller";
            Products = await _data.LoadData<ProductModel, dynamic>(sql1, new { Seller = this.Seller }, _config.GetConnectionString("default"));

            return await Task.FromResult(true);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);

            return await Task.FromResult(false);
        }
    }

    public void SetCoverImage()
    {
        this.coverImagePath = StoreModel.CoverImagePath;
    }

    public void SetStoreIcon()
    {
        this.storeIconPath = StoreModel.StoreIconPath;
    }

    private async Task<bool> ValidateStore()
    {
        if (this.exists)
        {
            await UpdateStore();

            return await Task.FromResult(true);
        }

        return await Task.FromResult(false);
    }

    private async Task<bool> UpdateStore()
    {
        try
        {
            string sql = "update stores set Name = @Name, UserID = @UserID, MainColor = @MainColor, " +
                "CoverImagePath = @CoverImagePath, StoreIconPath = @StoreIconPath, " +
                "Updated = @Updated, Registered = @Registered where StoreID = @StoreID";

            await _data.SaveData(sql, new
            {
                StoreID = StoreModel.StoreID,
                Name = StoreModel.Name,
                UserID = StoreModel.UserID,
                MainColor = this.mainColor,
                CoverImagePath = this.coverImagePath,
                StoreIconPath = this.storeIconPath,
                Updated = DateTime.Now,
                Registered = StoreModel.Registered
            }, _config.GetConnectionString("default"));

            await OnInitializedAsync();

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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataAccess _data { get; set; }
    }
}
#pragma warning restore 1591
