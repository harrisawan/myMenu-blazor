#pragma checksum "D:\new project\MyMenu\Client\Shared\AdminLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f0fc5b80e8a933f817ef5822d8731c5795766d1"
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
    public partial class AdminLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudThemeProvider>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\n");
            __builder.OpenComponent<MudBlazor.MudDialogProvider>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\n");
            __builder.OpenComponent<MudBlazor.MudSnackbarProvider>(4);
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\n");
            __builder.OpenComponent<MudBlazor.MudLayout>(6);
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(8, "\n    ");
                __builder2.OpenComponent<MudBlazor.MudAppBar>(9);
                __builder2.AddAttribute(10, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 6 "D:\new project\MyMenu\Client\Shared\AdminLayout.razor"
                          4

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(12, "\n        ");
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(13);
                    __builder3.AddAttribute(14, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 7 "D:\new project\MyMenu\Client\Shared\AdminLayout.razor"
                              Icons.Material.Filled.Menu

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(15, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 7 "D:\new project\MyMenu\Client\Shared\AdminLayout.razor"
                                                                 Color.Inherit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(16, "Edge", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Edge>(
#nullable restore
#line 7 "D:\new project\MyMenu\Client\Shared\AdminLayout.razor"
                                                                                      Edge.Start

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(17, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "D:\new project\MyMenu\Client\Shared\AdminLayout.razor"
                                                                                                             (e) => DrawerToggle()

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(18, "\n        ");
                    __builder3.OpenComponent<MudBlazor.MudAppBarSpacer>(19);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(20, "\n\n        ");
                    __builder3.OpenComponent<MudBlazor.MudLink>(21);
                    __builder3.AddAttribute(22, "Href", "#");
                    __builder3.AddAttribute(23, "Class", "pa-2 mud-theme-primary");
                    __builder3.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(25, "Company Name");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(26, "\n        ");
                    __builder3.OpenComponent<MudBlazor.MudLink>(27);
                    __builder3.AddAttribute(28, "Href", "#");
                    __builder3.AddAttribute(29, "Class", "pa-2 mud-theme-primary");
                    __builder3.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(31, "Logout");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(32, "\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\n    ");
                __builder2.OpenComponent<MudBlazor.MudDrawer>(34);
                __builder2.AddAttribute(35, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 15 "D:\new project\MyMenu\Client\Shared\AdminLayout.razor"
                                                   4

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "Open", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "D:\new project\MyMenu\Client\Shared\AdminLayout.razor"
                           _drawerOpen

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "OpenChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _drawerOpen = __value, _drawerOpen))));
                __builder2.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(39, "\n        ");
                    __builder3.OpenComponent<MudBlazor.MudDrawerHeader>(40);
                    __builder3.AddAttribute(41, "Style", "padding-left: 67px;");
                    __builder3.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(43, "\n            ");
                        __builder4.OpenElement(44, "div");
                        __builder4.AddAttribute(45, "class", "d-flex justify-center");
                        __builder4.AddMarkupContent(46, "\n                ");
                        __builder4.OpenComponent<MudBlazor.MudAvatar>(47);
                        __builder4.AddAttribute(48, "Image", "/images/userdefault.png");
                        __builder4.AddAttribute(49, "Style", "height:80px; width:80px;");
                        __builder4.AddAttribute(50, "Class", "ma-2");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(51, "\n            ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(52, "\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(53, "\n        ");
                    __builder3.OpenComponent<MudBlazor.MudNavMenu>(54);
                    __builder3.AddAttribute(55, "Class", "mud-width-full");
                    __builder3.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(57, "\n            ");
                        __builder4.OpenComponent<MudBlazor.MudDivider>(58);
                        __builder4.AddAttribute(59, "Class", "my-2");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(60, "\n            ");
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(61);
                        __builder4.AddAttribute(62, "Href", "/adminHome");
                        __builder4.AddAttribute(63, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "D:\new project\MyMenu\Client\Shared\AdminLayout.razor"
                                                 Icons.Material.Filled.Home

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(65, "Home");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(66, "\n            ");
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(67);
                        __builder4.AddAttribute(68, "Href", "#");
                        __builder4.AddAttribute(69, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "D:\new project\MyMenu\Client\Shared\AdminLayout.razor"
                                        Icons.Material.Filled.Money

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(71, "Payments");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(72, "\n            ");
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(73);
                        __builder4.AddAttribute(74, "Href", "/addcompany");
                        __builder4.AddAttribute(75, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "D:\new project\MyMenu\Client\Shared\AdminLayout.razor"
                                                  Icons.Material.Filled.HomeWork

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(76, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(77, "Company");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(78, "\n            ");
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(79);
                        __builder4.AddAttribute(80, "Href", "/menu");
                        __builder4.AddAttribute(81, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "D:\new project\MyMenu\Client\Shared\AdminLayout.razor"
                                            Icons.Material.Filled.RestaurantMenu

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(82, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(83, "Menus");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(84, "\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(85, "\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(86, "\n    ");
                __builder2.OpenComponent<MudBlazor.MudMainContent>(87);
                __builder2.AddAttribute(88, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(89, "\n        ");
                    __builder3.AddContent(90, 
#nullable restore
#line 30 "D:\new project\MyMenu\Client\Shared\AdminLayout.razor"
         Body

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(91, "\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(92, "\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "D:\new project\MyMenu\Client\Shared\AdminLayout.razor"
        bool _drawerOpen = true;

    void DrawerToggle()
    {
        _drawerOpen = !_drawerOpen;
    } 

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591