#pragma checksum "D:\new project\MyMenu\Client\Pages\AddCompany.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef2a9ad7e0095b96869e57c13eaffb74cc59671f"
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
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AdminLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/addcompany")]
    public partial class AddCompany : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "Class", "d-flex justify-center py-2 px-1 mt-6");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<MudBlazor.MudPaper>(3);
            __builder.AddAttribute(4, "Class", "pa-6 mx-2 mud-elevation-16");
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(6, "\r\n        ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "Class", "py-2 px-1 mt-1");
                __builder2.AddMarkupContent(9, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudText>(10);
                __builder2.AddAttribute(11, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 7 "D:\new project\MyMenu\Client\Pages\AddCompany.razor"
                           Typo.h4

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "Align", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Align>(
#nullable restore
#line 7 "D:\new project\MyMenu\Client\Pages\AddCompany.razor"
                                           Align.Center

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 7 "D:\new project\MyMenu\Client\Pages\AddCompany.razor"
                                                                Color.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(15, "<b>NEW COMPANY</b>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudDivider>(17);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudGrid>(20);
                __builder2.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(22, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(23);
                    __builder3.AddAttribute(24, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 11 "D:\new project\MyMenu\Client\Pages\AddCompany.razor"
                         12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(26, "\r\n                ");
                        __builder4.OpenElement(27, "div");
                        __builder4.AddAttribute(28, "class", " mt-4");
                        __builder4.AddMarkupContent(29, "\r\n                    ");
                        __builder4.OpenElement(30, "div");
                        __builder4.AddAttribute(31, "class", "d-inline");
                        __builder4.AddMarkupContent(32, "\r\n\r\n                        ");
                        __builder4.OpenComponent<MudBlazor.MudButton>(33);
                        __builder4.AddAttribute(34, "HtmlTag", "label");
                        __builder4.AddAttribute(35, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 17 "D:\new project\MyMenu\Client\Pages\AddCompany.razor"
                                            Variant.Filled

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(36, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 18 "D:\new project\MyMenu\Client\Pages\AddCompany.razor"
                                          Color.Primary

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(37, "StartIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "D:\new project\MyMenu\Client\Pages\AddCompany.razor"
                                               Icons.Filled.Image

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(38, "for", "fileInput");
                        __builder4.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(40, "\r\n                            Upload Logo\r\n                        ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(41, "\r\n                    ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(42, "\r\n                    ");
                        __builder4.AddMarkupContent(43, "<div class=\"d-inline pa-2\"><input type=\"file\" id=\"fileInput\" name=\"fileInput\" hidden></div>\r\n                ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(44, "\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(45, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(46);
                    __builder3.AddAttribute(47, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 27 "D:\new project\MyMenu\Client\Pages\AddCompany.razor"
                         12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(49, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudTextField<string>>(50);
                        __builder4.AddAttribute(51, "Label", "Company Name");
                        __builder4.AddAttribute(52, "Required", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 28 "D:\new project\MyMenu\Client\Pages\AddCompany.razor"
                                                                        true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(53, "RequiredError", "Company Name is required!");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(54, "\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(55, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(56);
                    __builder3.AddAttribute(57, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 30 "D:\new project\MyMenu\Client\Pages\AddCompany.razor"
                         12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(59, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudTextField<string>>(60);
                        __builder4.AddAttribute(61, "Label", "Company Moto");
                        __builder4.AddAttribute(62, "Required", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 31 "D:\new project\MyMenu\Client\Pages\AddCompany.razor"
                                                                        true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(63, "RequiredError", "Company Moto is required!");
                        __builder4.AddAttribute(64, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 31 "D:\new project\MyMenu\Client\Pages\AddCompany.razor"
                                                                                                                                 Variant.Text

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(65, "Lines", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 31 "D:\new project\MyMenu\Client\Pages\AddCompany.razor"
                                                                                                                                                      5

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(66, "\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(67, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(68);
                    __builder3.AddAttribute(69, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 33 "D:\new project\MyMenu\Client\Pages\AddCompany.razor"
                         12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(70, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 33 "D:\new project\MyMenu\Client\Pages\AddCompany.razor"
                                 12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(71, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(72, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudButton>(73);
                        __builder4.AddAttribute(74, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 34 "D:\new project\MyMenu\Client\Pages\AddCompany.razor"
                                    Variant.Filled

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(75, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 34 "D:\new project\MyMenu\Client\Pages\AddCompany.razor"
                                                           Color.Primary

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(76, "Class", "mt-2");
                        __builder4.AddAttribute(77, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(78, "Save");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(79, "\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(80, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(81, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(82, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "D:\new project\MyMenu\Client\Pages\AddCompany.razor"
       
    //IList<IBrowserFile> files = new List<IBrowserFile>();
    private void UploadFiles()
    {
        //foreach (var file in e.GetMultipleFiles())
        //{
        //    files.Add(file);
        //}
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591