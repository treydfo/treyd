#pragma checksum "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Pages\OrdersPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "005553a9f821a55e2de136bba83735c42b7e1dd9"
// <auto-generated/>
#pragma warning disable 1591
namespace treyd.Pages
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
#line 3 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Pages\OrdersPage.razor"
using DataLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Pages\OrdersPage.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Pages\OrdersPage.razor"
using Microsoft.AspNetCore.WebUtilities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/brukari/bileggingar")]
    public partial class OrdersPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "div");
                __builder2.AddAttribute(3, "class", "container");
                __builder2.AddMarkupContent(4, "<h1 class=\"h3 mt-4 mb-3 fw-normal text-info text-center\">T??nar b??leggingar</h1>\r\n            <hr>\r\n            ");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "accordion");
                __builder2.AddAttribute(7, "id", "accordionExample");
#nullable restore
#line 20 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Pages\OrdersPage.razor"
                 if (Orders != null && OrderItems != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Pages\OrdersPage.razor"
                     foreach (var order in Orders)
                    {
                        this.count++;

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "accordion-item text-info");
                __builder2.AddAttribute(10, "style", "background: white;");
                __builder2.OpenElement(11, "h2");
                __builder2.AddAttribute(12, "class", "accordion-header");
                __builder2.AddAttribute(13, "id", "heading" + (
#nullable restore
#line 26 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Pages\OrdersPage.razor"
                                                                      this.count

#line default
#line hidden
#nullable disable
                ));
                __builder2.OpenElement(14, "button");
                __builder2.AddAttribute(15, "class", "accordion-button");
                __builder2.AddAttribute(16, "type", "button");
                __builder2.AddAttribute(17, "data-bs-toggle", "collapse");
                __builder2.AddAttribute(18, "data-bs-target", "#collapse" + (
#nullable restore
#line 27 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Pages\OrdersPage.razor"
                                                                                                                                    this.count

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "aria-expanded", "true");
                __builder2.AddAttribute(20, "aria-controls", "collapse" + (
#nullable restore
#line 27 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Pages\OrdersPage.razor"
                                                                                                                                                                                               this.count

#line default
#line hidden
#nullable disable
                ));
                __builder2.OpenElement(21, "table");
                __builder2.OpenElement(22, "tr");
                __builder2.AddMarkupContent(23, "<td>B??leggingarnummar: </td>\r\n                                            ");
                __builder2.OpenElement(24, "td");
                __builder2.AddContent(25, 
#nullable restore
#line 31 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Pages\OrdersPage.razor"
                                                 order.OrderNumber

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n                                        ");
                __builder2.OpenElement(27, "tr");
                __builder2.AddMarkupContent(28, "<td>B??lagt: </td>\r\n                                            ");
                __builder2.OpenElement(29, "td");
                __builder2.AddContent(30, 
#nullable restore
#line 35 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Pages\OrdersPage.razor"
                                                 order.DateOrdered.Date

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                                        ");
                __builder2.OpenElement(32, "tr");
                __builder2.AddMarkupContent(33, "<td>?? alt: </td>\r\n                                            ");
                __builder2.OpenElement(34, "td");
                __builder2.AddContent(35, 
#nullable restore
#line 39 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Pages\OrdersPage.razor"
                                                 order.Total.ToString("N2")

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n                            ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "id", "collapse" + (
#nullable restore
#line 44 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Pages\OrdersPage.razor"
                                               this.count

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "class", "accordion-collapse collapse");
                __builder2.AddAttribute(40, "aria-labelledby", "heading" + (
#nullable restore
#line 44 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Pages\OrdersPage.razor"
                                                                                                                          this.count

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "data-bs-parent", "#accordionExample");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "accordion-body text-info");
#nullable restore
#line 46 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Pages\OrdersPage.razor"
                                     foreach (var item in OrderItems)
                                    {
                                        if (item.OrderID.Equals(order.OrderID))
                                        {


#line default
#line hidden
#nullable disable
                __builder2.OpenElement(44, "table");
                __builder2.OpenElement(45, "tr");
                __builder2.AddMarkupContent(46, "<td>V??ruheiti: </td>\r\n                                                    ");
                __builder2.OpenElement(47, "td");
                __builder2.AddContent(48, 
#nullable restore
#line 54 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Pages\OrdersPage.razor"
                                                         item.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n                                                ");
                __builder2.OpenElement(50, "tr");
                __builder2.AddMarkupContent(51, "<td>V??rul??sing: </td>\r\n                                                    ");
                __builder2.OpenElement(52, "td");
                __builder2.AddContent(53, 
#nullable restore
#line 58 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Pages\OrdersPage.razor"
                                                         item.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n                                                ");
                __builder2.OpenElement(55, "tr");
                __builder2.AddMarkupContent(56, "<td>N??gd: </td>\r\n                                                    ");
                __builder2.OpenElement(57, "td");
                __builder2.AddContent(58, 
#nullable restore
#line 62 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Pages\OrdersPage.razor"
                                                         item.Amount

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n                                                ");
                __builder2.OpenElement(60, "tr");
                __builder2.AddMarkupContent(61, "<td>Pr??sur: </td>\r\n                                                    ");
                __builder2.OpenElement(62, "td");
                __builder2.AddContent(63, 
#nullable restore
#line 66 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Pages\OrdersPage.razor"
                                                         item.Subtotal.ToString("N2")

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n                                            <br>");
#nullable restore
#line 70 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Pages\OrdersPage.razor"
                                        }
                                    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 75 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Pages\OrdersPage.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Pages\OrdersPage.razor"
                     
                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(65, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenComponent<treyd.Components.Redirects.IndexRedirect>(66);
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 85 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Pages\OrdersPage.razor"
       
    private int count { get; set; } = 0;

    private UserModel User { get; set; }
    private AuthModel Auth { get; set; }

    private List<OrderItemsModel> OrderItems;
    private List<OrderModel> Orders;

    protected override async Task OnInitializedAsync()
    {
        if (await ((TreydAuthenticationStateProvider)AuthenticationStateProvider).GetAuthenticationStateAsync() is not null)
        {
            var result = await SessionStorage.GetAsync<AuthModel>("user");
            Auth = result.Success ? result.Value : null;
        }

        await LoadUser();
        await LoadOrders();
        await LoadOrderItems();
    }

    protected async Task<bool> LoadUser()
    {
        try
        {
            string sql = "select * from users where Email = @Email";
            User = await _data.QuerySingle<UserModel, dynamic>(sql, new { Email = Auth.Email }, _config.GetConnectionString("default"));

            return await Task.FromResult(true);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);

            return await Task.FromResult(false);
        }
    }

    protected async Task<bool> LoadOrders()
    {
        try
        {
            string sql = "select * from orders where orders.UserID = @UserID";
            Orders = await _data.LoadData<OrderModel, dynamic>(sql, new { UserID = User.UserID }, _config.GetConnectionString("default"));

            return await Task.FromResult(true);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);

            return await Task.FromResult(false);
        }
    }

    protected async Task<bool> LoadOrderItems()
    {
        try
        {
            string sql = "select * from order_items " +
                    "inner join products " +
                    "on order_items.ProductID = products.ProductID " +
                    "inner join orders " +
                    "on order_items.OrderID = orders.OrderID " +
                    "where orders.UserID = @UserID";
            OrderItems = await _data.LoadData<OrderItemsModel, dynamic>(sql, new { UserID = User.UserID }, _config.GetConnectionString("default"));

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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedSessionStorage SessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private StateContainer StateContainer { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataAccess _data { get; set; }
    }
}
#pragma warning restore 1591
