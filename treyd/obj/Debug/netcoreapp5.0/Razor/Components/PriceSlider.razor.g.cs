#pragma checksum "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\PriceSlider.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48e000df46a6e97543ac99829784e259ec653a64"
// <auto-generated/>
#pragma warning disable 1591
namespace treyd.Components
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
    public partial class PriceSlider : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "control-wrapper");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "slider-content-wrapper");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "slider_container");
#nullable restore
#line 6 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\PriceSlider.razor"
             if (StateContainer.PriceRange != null)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", 
#nullable restore
#line 8 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\PriceSlider.razor"
                             ThemeClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(8, 
#nullable restore
#line 8 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\PriceSlider.razor"
                                          StateContainer.PriceRange[0]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(9, " - ");
            __builder.AddContent(10, 
#nullable restore
#line 8 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\PriceSlider.razor"
                                                                          StateContainer.PriceRange[1]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 9 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\PriceSlider.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", 
#nullable restore
#line 12 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\PriceSlider.razor"
                             ThemeClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(13, "0 - 50000");
            __builder.CloseElement();
#nullable restore
#line 13 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\PriceSlider.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Syncfusion.Blazor.Inputs.SfSlider<double[]>>(14);
            __builder.AddAttribute(15, "Min", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 15 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\PriceSlider.razor"
                           0

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "Max", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 15 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\PriceSlider.razor"
                                   50000

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Inputs.SliderType>(
#nullable restore
#line 15 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\PriceSlider.razor"
                                                                    SliderType.Range

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "ID", "slider");
            __builder.AddAttribute(19, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<double[]>(
#nullable restore
#line 15 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\PriceSlider.razor"
                                                        Value

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<double[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<double[]>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Value = __value, Value))));
            __builder.AddAttribute(21, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<double[]>>>(() => Value));
            __builder.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Inputs.SliderTicks>(23);
                __builder2.AddAttribute(24, "ShowSmallTicks", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\PriceSlider.razor"
                                             true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "LargeStep", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 16 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\PriceSlider.razor"
                                                              100

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "SmallStep", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 16 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\PriceSlider.razor"
                                                                              50

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n                ");
                __builder2.OpenComponent<Syncfusion.Blazor.Inputs.SliderEvents<double[]>>(28);
                __builder2.AddAttribute(29, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Inputs.SliderChangeEventArgs<double[]>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Inputs.SliderChangeEventArgs<double[]>>(this, 
#nullable restore
#line 17 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\PriceSlider.razor"
                                                          OnSliderChange

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(30, "Created", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Object>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Object>(this, 
#nullable restore
#line 17 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\PriceSlider.razor"
                                                                                   OnSliderCreated

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(32, @"<style>
    .userselect {
        -webkit-user-select: none; /* Safari 3.1+ */
        -moz-user-select: none; /* Firefox 2+ */
        -ms-user-select: none; /* IE 10+ */
        user-select: none; /* Standard syntax */
    }

    #slider.e-control.e-slider .e-handle {
        height: 25px;
        width: 8px;
        top: 3px;
        border-radius: 15px;
        background-color: #0e3976;
    }

    #slider.e-tab-handle::after {
        background-color: #f9920b;
    }

    #slider.e-control.e-slider .e-slider-track {
        height: 8px;
        top: calc(50% - 4px);
        border-radius: 0;
    }

    .e-control-wrapper.e-slider-container .e-slider .e-range {
        background-color: #0e3976;
    }

    .highcontrast #slider.e-control.e-slider .e-slider-track {
        height: 10px;
        top: calc(50% - 5px);
        border-radius: 0;
    }

    .fabric .slider_container .e-slider-hover .e-slider-track,
    .fabric .slider_container .e-slider-container:active .e-slider-track,
    .fabric .slider_container .e-slider-container .e-slider .e-tab-track {
        background-color: #c8c8c8;
    }
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\jonsi\ASP.NETProjects\treyd\treyd\treyd\Components\PriceSlider.razor"
       
    public double[] Value;
    public string ThemeClass;

    [Parameter] public string Theme { get; set; }

    private void SetTheme()
    {
        if (Theme == "Dark")
        {
            this.ThemeClass =
                "text-sm-center " +
                "text-light";
        }
        if (Theme == "Light")
        {
            this.ThemeClass =
                "text-sm-center " +
                "text-muted";
        }
    }

    protected override async Task OnInitializedAsync()
    {
        SetTheme();
    }

    public void OnSliderChange(SliderChangeEventArgs<double[]> Args)
    {
        SetRangeState();
    }

    public void OnSliderCreated()
    {
        //SetRangeState();
    }

    private void SetRangeState()
    {
        StateContainer.GetPriceRangeState(Value);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private StateContainer StateContainer { get; set; }
    }
}
#pragma warning restore 1591
