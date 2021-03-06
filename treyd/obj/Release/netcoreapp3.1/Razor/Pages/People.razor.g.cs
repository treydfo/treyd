#pragma checksum "C:\Forritan\Visual Studio 2019\Projects\treyd\treyd\treyd\Pages\People.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74530174aaa6de3eb00924ac47bf275ef9b7da2e"
// <auto-generated/>
#pragma warning disable 1591
namespace treyd.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Forritan\Visual Studio 2019\Projects\treyd\treyd\treyd\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Forritan\Visual Studio 2019\Projects\treyd\treyd\treyd\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Forritan\Visual Studio 2019\Projects\treyd\treyd\treyd\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Forritan\Visual Studio 2019\Projects\treyd\treyd\treyd\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Forritan\Visual Studio 2019\Projects\treyd\treyd\treyd\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Forritan\Visual Studio 2019\Projects\treyd\treyd\treyd\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Forritan\Visual Studio 2019\Projects\treyd\treyd\treyd\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Forritan\Visual Studio 2019\Projects\treyd\treyd\treyd\_Imports.razor"
using treyd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Forritan\Visual Studio 2019\Projects\treyd\treyd\treyd\_Imports.razor"
using treyd.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Forritan\Visual Studio 2019\Projects\treyd\treyd\treyd\Pages\People.razor"
using DataLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Forritan\Visual Studio 2019\Projects\treyd\treyd\treyd\Pages\People.razor"
using treyd.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Forritan\Visual Studio 2019\Projects\treyd\treyd\treyd\Pages\People.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/people")]
    public partial class People : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>People</h3>\r\n\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "class", "btn btn-primary");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Forritan\Visual Studio 2019\Projects\treyd\treyd\treyd\Pages\People.razor"
                                          InsertData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(4, "Insert");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "class", "btn btn-warning");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Forritan\Visual Studio 2019\Projects\treyd\treyd\treyd\Pages\People.razor"
                                          UpdateData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(9, "Update");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "class", "btn btn-danger");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Forritan\Visual Studio 2019\Projects\treyd\treyd\treyd\Pages\People.razor"
                                         DeleteData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(14, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\r\n");
#nullable restore
#line 15 "C:\Forritan\Visual Studio 2019\Projects\treyd\treyd\treyd\Pages\People.razor"
 if (people == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "    ");
            __builder.AddMarkupContent(17, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 18 "C:\Forritan\Visual Studio 2019\Projects\treyd\treyd\treyd\Pages\People.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "    ");
            __builder.OpenElement(19, "table");
            __builder.AddAttribute(20, "class", "table");
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.AddMarkupContent(22, "<thead>\r\n            <tr>\r\n                <th>First Name</th>\r\n                <th>Last Name</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(23, "tbody");
            __builder.AddMarkupContent(24, "\r\n");
#nullable restore
#line 29 "C:\Forritan\Visual Studio 2019\Projects\treyd\treyd\treyd\Pages\People.razor"
             foreach (var p in people)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(25, "                ");
            __builder.OpenElement(26, "tr");
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 32 "C:\Forritan\Visual Studio 2019\Projects\treyd\treyd\treyd\Pages\People.razor"
                         p.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 33 "C:\Forritan\Visual Studio 2019\Projects\treyd\treyd\treyd\Pages\People.razor"
                         p.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
#nullable restore
#line 35 "C:\Forritan\Visual Studio 2019\Projects\treyd\treyd\treyd\Pages\People.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n");
#nullable restore
#line 38 "C:\Forritan\Visual Studio 2019\Projects\treyd\treyd\treyd\Pages\People.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Forritan\Visual Studio 2019\Projects\treyd\treyd\treyd\Pages\People.razor"
       
    List<PersonModel> people;

    private async Task InsertData()
    {
        string sql = "insert into people (FirstName, LastName) values (@FirstName, @LastName);";

        await _data.SaveData(sql, new { FirstName = "Billy", LastName = "Bob" }, _config.GetConnectionString("default"));

        await OnInitializedAsync();
    }

    private async Task UpdateData()
    {
        string sql = "update people set FirstName = @FirstName where LastName = @LastName";

        await _data.SaveData(sql, new { FirstName = "Timothy", LastName = "Bob" }, _config.GetConnectionString("default"));

        await OnInitializedAsync();
    }

    private async Task DeleteData()
    {
        string sql = "delete from people where LastName = @LastName";

        await _data.SaveData(sql, new { LastName = "Bob" }, _config.GetConnectionString("default"));

        await OnInitializedAsync();
    }

    protected override async Task OnInitializedAsync()
    {
        string sql = "select * from people";

        people = await _data.LoadData<PersonModel, dynamic>(sql, new { }, _config.GetConnectionString("default"));
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataAccess _data { get; set; }
    }
}
#pragma warning restore 1591
