#pragma checksum "C:\Users\alexa\source\repos\U1_API\Blazor\Pages\RegisterUser.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "210ed73c7403e3bcb1d890d002b1ccf5846fc467"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\alexa\source\repos\U1_API\Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alexa\source\repos\U1_API\Blazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\alexa\source\repos\U1_API\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\alexa\source\repos\U1_API\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\alexa\source\repos\U1_API\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\alexa\source\repos\U1_API\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\alexa\source\repos\U1_API\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\alexa\source\repos\U1_API\Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\alexa\source\repos\U1_API\Blazor\_Imports.razor"
using Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\alexa\source\repos\U1_API\Blazor\_Imports.razor"
using Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\alexa\source\repos\U1_API\Blazor\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/registeruser")]
    public partial class RegisterUser : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Add User</h1>\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates sending data to a webapi.</p>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "C:\Users\alexa\source\repos\U1_API\Blazor\Pages\RegisterUser.razor"
                  user

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 8 "C:\Users\alexa\source\repos\U1_API\Blazor\Pages\RegisterUser.razor"
                                   CreateUserAsync

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "form-group");
                __builder2.OpenElement(8, "input");
                __builder2.AddAttribute(9, "type", "text");
                __builder2.AddAttribute(10, "class", "form-control");
                __builder2.AddAttribute(11, "placeholder", "First Name");
                __builder2.AddAttribute(12, "required");
                __builder2.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "C:\Users\alexa\source\repos\U1_API\Blazor\Pages\RegisterUser.razor"
                                                                                user.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.FirstName = __value, user.FirstName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\r\n    ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "form-group");
                __builder2.OpenElement(18, "input");
                __builder2.AddAttribute(19, "type", "text");
                __builder2.AddAttribute(20, "class", "form-control");
                __builder2.AddAttribute(21, "placeholder", "Last Name");
                __builder2.AddAttribute(22, "required");
                __builder2.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\alexa\source\repos\U1_API\Blazor\Pages\RegisterUser.razor"
                                                                               user.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.LastName = __value, user.LastName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n    ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "form-group");
                __builder2.OpenElement(28, "input");
                __builder2.AddAttribute(29, "type", "text");
                __builder2.AddAttribute(30, "class", "form-control");
                __builder2.AddAttribute(31, "placeholder", "Email");
                __builder2.AddAttribute(32, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\alexa\source\repos\U1_API\Blazor\Pages\RegisterUser.razor"
                                                                           user.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.Email = __value, user.Email));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n    ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "form-group");
                __builder2.OpenElement(37, "input");
                __builder2.AddAttribute(38, "type", "password");
                __builder2.AddAttribute(39, "class", "form-control");
                __builder2.AddAttribute(40, "placeholder", "Password");
                __builder2.AddAttribute(41, "required");
                __builder2.AddAttribute(42, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\alexa\source\repos\U1_API\Blazor\Pages\RegisterUser.razor"
                                                                                  user.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.Password = __value, user.Password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n    ");
                __builder2.AddMarkupContent(45, "<div class=\"form-group\"><button type=\"submit\" class=\"btn btn-success\">Add user</button></div>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\alexa\source\repos\U1_API\Blazor\Pages\RegisterUser.razor"
       
    private RegUser user;

    private async Task CreateUserAsync()
    {
        await Http.PostAsJsonAsync<RegUser>("https://localhost:44338/api/Users/signup", user);
        user = new RegUser();
    }

    protected override void OnInitialized()
    {
        user = new RegUser();
    }

    public class RegUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
    }
}
#pragma warning restore 1591
