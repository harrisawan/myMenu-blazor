#pragma checksum "D:\new project\MyMenu\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d473ffbaf022fd5a6ae56d0298f359caf85e5eb2"
// <auto-generated/>
#pragma warning disable 1591
namespace MyMenu.Client.Pages
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
using MyMenu.Client.Services.Companies;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\new project\MyMenu\Client\_Imports.razor"
using MyMenu.Client.Services.Menus;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\new project\MyMenu\Client\_Imports.razor"
using MyMenu.Client.Services.Categories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\new project\MyMenu\Client\_Imports.razor"
using MyMenu.Client.Services.Items;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\new project\MyMenu\Client\_Imports.razor"
using MyMenu.Client.Services.Discounts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\new project\MyMenu\Client\_Imports.razor"
using MyMenu.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\new project\MyMenu\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\new project\MyMenu\Client\_Imports.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\new project\MyMenu\Client\_Imports.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\new project\MyMenu\Client\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\new project\MyMenu\Client\_Imports.razor"
using MyMenu.Shared.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\new project\MyMenu\Client\_Imports.razor"
using MyMenu.Client.Services.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\new project\MyMenu\Client\_Imports.razor"
using MyMenu.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\new project\MyMenu\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\new project\MyMenu\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\new project\MyMenu\Client\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\n    .container {\n        position: relative;\n        text-align: center;\n        color: white;\n    }\n\n    .centered {\n        position: absolute;\n        top: 50%;\n        left: 50%;\n        transform: translate(-50%, -50%);\n    }\n</style>\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.AddMarkupContent(3, "\n    <img src=\"/images/banner.jpg\" alt=\"Snow\" style=\"width:100%;\" class=\"mud-elevation-9\">\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "centered");
            __builder.AddMarkupContent(6, "\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "d-flex justify-center py-2 px-1");
            __builder.AddMarkupContent(9, "\n            ");
            __builder.OpenComponent<MudBlazor.MudText>(10);
            __builder.AddAttribute(11, "Align", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Align>(
#nullable restore
#line 20 "D:\new project\MyMenu\Client\Pages\Index.razor"
                            Align.Center

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "style", "font-size:8vw;text-shadow: 2px 2px 4px black;");
            __builder.AddAttribute(13, "GutterBottom", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "D:\new project\MyMenu\Client\Pages\Index.razor"
                                                                                                              true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(15, "MyMenu");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(16, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n");
            __builder.OpenComponent<MudBlazor.MudContainer>(20);
            __builder.AddAttribute(21, "Class", "mt-9");
            __builder.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(23, "\n    ");
                __builder2.OpenComponent<MudBlazor.MudGrid>(24);
                __builder2.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(26, "\n        ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(27);
                    __builder3.AddAttribute(28, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 27 "D:\new project\MyMenu\Client\Pages\Index.razor"
                     12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(29, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 27 "D:\new project\MyMenu\Client\Pages\Index.razor"
                             6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(31, "\n            ");
                        __builder4.AddMarkupContent(32, "<div class=\"d-flex justify-center py-2 px-1 mt-6\">\n                <img src=\"/images/photo4.jpg\" class=\"mud-elevation-21\">\n            </div>\n\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(33, "\n        ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(34);
                    __builder3.AddAttribute(35, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 33 "D:\new project\MyMenu\Client\Pages\Index.razor"
                     12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(36, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 33 "D:\new project\MyMenu\Client\Pages\Index.razor"
                             6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(38, "\n            ");
                        __builder4.AddMarkupContent(39, @"<div class=""d-flex justify-center py-2 px-2 mt-6"">
                <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.</p>

            </div>
        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(40, "\n        ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(41);
                    __builder3.AddAttribute(42, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 39 "D:\new project\MyMenu\Client\Pages\Index.razor"
                     12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(43, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 39 "D:\new project\MyMenu\Client\Pages\Index.razor"
                             6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(45, "\n            ");
                        __builder4.AddMarkupContent(46, @"<div class=""d-flex justify-center py-2 px-2 mt-6"">

                <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.</p>

            </div>
        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(47, "\n        ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(48);
                    __builder3.AddAttribute(49, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 46 "D:\new project\MyMenu\Client\Pages\Index.razor"
                     12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(50, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 46 "D:\new project\MyMenu\Client\Pages\Index.razor"
                             6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(52, "\n            ");
                        __builder4.AddMarkupContent(53, "<div class=\"d-flex justify-center py-2 px-1 mt-6\">\n                <img src=\"/images/photo3.jpg\" class=\"mud-elevation-21\">\n            </div>\n\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(54, "\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(55, "\n\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
