#pragma checksum "D:\new project\MyMenu\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ecbc0c09ae707ba5742ee4b06f3b1f7b85943d4"
// <auto-generated/>
#pragma warning disable 1591
namespace MyMenu.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\new project\MyMenu\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\new project\MyMenu\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\new project\MyMenu\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\new project\MyMenu\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\new project\MyMenu\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\new project\MyMenu\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\new project\MyMenu\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\new project\MyMenu\Client\_Imports.razor"
using MyMenu.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\new project\MyMenu\Client\_Imports.razor"
using MyMenu.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\new project\MyMenu\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\new project\MyMenu\Client\_Imports.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\new project\MyMenu\Client\_Imports.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudNavMenu>(0);
            __builder.AddAttribute(1, "Class", "mud-width-full");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudDivider>(4);
                __builder2.AddAttribute(5, "Class", "my-2");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudNavLink>(7);
                __builder2.AddAttribute(8, "Href", "/");
                __builder2.AddAttribute(9, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 3 "D:\new project\MyMenu\Client\Shared\NavMenu.razor"
                                Icons.Material.Filled.Home

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(11, "Home");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudNavLink>(13);
                __builder2.AddAttribute(14, "Href", "/pricepackage");
                __builder2.AddAttribute(15, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 4 "D:\new project\MyMenu\Client\Shared\NavMenu.razor"
                                            Icons.Material.Filled.Money

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(17, "Prices");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudNavLink>(19);
                __builder2.AddAttribute(20, "Href", "/about");
                __builder2.AddAttribute(21, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 5 "D:\new project\MyMenu\Client\Shared\NavMenu.razor"
                                     Icons.Material.Filled.Info

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(23, "About");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudNavLink>(25);
                __builder2.AddAttribute(26, "Href", "/contact");
                __builder2.AddAttribute(27, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 6 "D:\new project\MyMenu\Client\Shared\NavMenu.razor"
                                       Icons.Material.Filled.ContactPage

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(29, "Contact");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
