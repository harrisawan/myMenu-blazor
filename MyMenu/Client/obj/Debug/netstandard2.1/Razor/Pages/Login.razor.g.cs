#pragma checksum "D:\new project\MyMenu\Client\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4c012adee51a82ead60dfb3cbb8aeb879736133"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"css/responsive-full-background-image.css\" rel=\"stylesheet\">\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "content");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "Class", "d-flex justify-space-between py-2 px-1 mt-6");
            __builder.AddAttribute(9, "Elevation", "0");
            __builder.AddMarkupContent(10, "\r\n            <div class mx-2\" Elevation=\"0\"></div>\r\n            ");
            __builder.OpenComponent<MudBlazor.MudPaper>(11);
            __builder.AddAttribute(12, "Class", "d-flex mx-2 mud-elevation-14");
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(14, "\r\n                ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "id", "loginformsize");
                __builder2.AddAttribute(17, "style", "width:380px;");
                __builder2.AddMarkupContent(18, "\r\n                    ");
                __builder2.OpenComponent<MudBlazor.MudCard>(19);
                __builder2.AddAttribute(20, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 10 "D:\new project\MyMenu\Client\Pages\Login.razor"
                                        0

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "Class", "py-2");
                __builder2.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(23, "\r\n                        ");
                    __builder3.OpenComponent<MudBlazor.MudCardContent>(24);
                    __builder3.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(26, "\r\n                            ");
                        __builder4.OpenComponent<MudBlazor.MudText>(27);
                        __builder4.AddAttribute(28, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 12 "D:\new project\MyMenu\Client\Pages\Login.razor"
                                           Typo.h5

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(29, "Align", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Align>(
#nullable restore
#line 12 "D:\new project\MyMenu\Client\Pages\Login.razor"
                                                           Align.Center

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(31, "<b>Login</b>");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(32, "\r\n");
#nullable restore
#line 13 "D:\new project\MyMenu\Client\Pages\Login.razor"
                             foreach (var error in errors)
                            {

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(33, "                                ");
                        __builder4.OpenComponent<MudBlazor.MudAlert>(34);
                        __builder4.AddAttribute(35, "Severity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Severity>(
#nullable restore
#line 15 "D:\new project\MyMenu\Client\Pages\Login.razor"
                                                    Severity.Error

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(36, "NoIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "D:\new project\MyMenu\Client\Pages\Login.razor"
                                                                            false

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(38, 
#nullable restore
#line 15 "D:\new project\MyMenu\Client\Pages\Login.razor"
                                                                                    error

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(39, "\r\n");
#nullable restore
#line 16 "D:\new project\MyMenu\Client\Pages\Login.razor"
                            }

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(40, "                            ");
                        __builder4.OpenComponent<MudBlazor.MudForm>(41);
                        __builder4.AddAttribute(42, "IsValid", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "D:\new project\MyMenu\Client\Pages\Login.razor"
                                                                 success

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(43, "IsValidChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => success = __value, success))));
                        __builder4.AddAttribute(44, "Errors", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String[]>(
#nullable restore
#line 17 "D:\new project\MyMenu\Client\Pages\Login.razor"
                                                                                         errors

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(45, "ErrorsChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String[]>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => errors = __value, errors))));
                        __builder4.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(47, "\r\n                                ");
                            __builder5.OpenComponent<MudBlazor.MudTextField<string>>(48);
                            __builder5.AddAttribute(49, "Label", "Email");
                            __builder5.AddAttribute(50, "Required", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "D:\new project\MyMenu\Client\Pages\Login.razor"
                                                                                 true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(51, "RequiredError", "Email is required!");
                            __builder5.AddAttribute(52, "Validation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 19 "D:\new project\MyMenu\Client\Pages\Login.razor"
                                                            new EmailAddressAttribute() {ErrorMessage = "The email address is invalid"}

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(53, "\r\n                                ");
                            __builder5.OpenComponent<MudBlazor.MudTextField<string>>(54);
                            __builder5.AddAttribute(55, "Label", "Password");
                            __builder5.AddAttribute(56, "InputType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.InputType>(
#nullable restore
#line 21 "D:\new project\MyMenu\Client\Pages\Login.razor"
                                                         InputType.Password

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(57, "Validation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 22 "D:\new project\MyMenu\Client\Pages\Login.razor"
                                                            new Func<string, IEnumerable<string>>(PasswordStrength)

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(58, "Required", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 22 "D:\new project\MyMenu\Client\Pages\Login.razor"
                                                                                                                                true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(59, "RequiredError", "Password is required!");
                            __builder5.AddComponentReferenceCapture(60, (__value) => {
#nullable restore
#line 20 "D:\new project\MyMenu\Client\Pages\Login.razor"
                                                                                pwField1 = (MudBlazor.MudTextField<string>)__value;

#line default
#line hidden
#nullable disable
                            }
                            );
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(61, "\r\n                            ");
                        }
                        ));
                        __builder4.AddComponentReferenceCapture(62, (__value) => {
#nullable restore
#line 17 "D:\new project\MyMenu\Client\Pages\Login.razor"
                                           form = (MudBlazor.MudForm)__value;

#line default
#line hidden
#nullable disable
                        }
                        );
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(63, "\r\n                            ");
                        __builder4.OpenComponent<MudBlazor.MudText>(64);
                        __builder4.AddAttribute(65, "Align", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Align>(
#nullable restore
#line 25 "D:\new project\MyMenu\Client\Pages\Login.razor"
                                            Align.Right

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(66, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudLink>(67);
                            __builder5.AddAttribute(68, "Href", "/register");
                            __builder5.AddAttribute(69, "Underline", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Underline>(
#nullable restore
#line 25 "D:\new project\MyMenu\Client\Pages\Login.razor"
                                                                                              Underline.Hover

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(71, "Forgot Password?");
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(72, "\r\n                        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(73, "\r\n                        ");
                    __builder3.OpenComponent<MudBlazor.MudCardActions>(74);
                    __builder3.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(76, "\r\n                            ");
                        __builder4.OpenComponent<MudBlazor.MudButton>(77);
                        __builder4.AddAttribute(78, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 28 "D:\new project\MyMenu\Client\Pages\Login.razor"
                                                Variant.Filled

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(79, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 28 "D:\new project\MyMenu\Client\Pages\Login.razor"
                                                                       Color.Primary

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(80, "Class", "ml-auto mr-3");
                        __builder4.AddAttribute(81, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(82, "Login");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(83, "\r\n                        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(84, "\r\n                        ");
                    __builder3.OpenComponent<MudBlazor.MudText>(85);
                    __builder3.AddAttribute(86, "Class", "px-2 pb-2");
                    __builder3.AddAttribute(87, "Align", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Align>(
#nullable restore
#line 30 "D:\new project\MyMenu\Client\Pages\Login.razor"
                                                          Align.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(88, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(89, " New User? ");
                        __builder4.OpenComponent<MudBlazor.MudLink>(90);
                        __builder4.AddAttribute(91, "Href", "/register");
                        __builder4.AddAttribute(92, "Underline", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Underline>(
#nullable restore
#line 30 "D:\new project\MyMenu\Client\Pages\Login.razor"
                                                                                                                        Underline.Always

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(93, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(94, "<b>Create an account</b>");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(95, "\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(96, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(97, "\r\n\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(98, "\r\n            <div class mx-2\" Elevation=\"0\"></div>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "D:\new project\MyMenu\Client\Pages\Login.razor"
       
    bool success;
    string[] errors = { };
    MudTextField<string> pwField1;
    MudForm form;
    private IEnumerable<string> PasswordStrength(string pw)
    {
        if (string.IsNullOrWhiteSpace(pw))
        {
            yield return "Password is required!";
            yield break;
        }
        if (pw.Length < 8)
            yield return "Password must be at least of length 8";
        if (!Regex.IsMatch(pw, @"[A-Z]"))
            yield return "Password must contain at least one capital letter";
        if (!Regex.IsMatch(pw, @"[a-z]"))
            yield return "Password must contain at least one lowercase letter";
        if (!Regex.IsMatch(pw, @"[0-9]"))
            yield return "Password must contain at least one digit";
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
