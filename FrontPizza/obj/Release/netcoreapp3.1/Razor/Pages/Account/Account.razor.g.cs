#pragma checksum "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Account\Account.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "879304b9bd50b01d0fe4712b45a4e4d08c1be167"
// <auto-generated/>
#pragma warning disable 1591
namespace FrontPizza.Pages.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\_Imports.razor"
using FrontPizza;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\_Imports.razor"
using FrontPizza.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\_Imports.razor"
using FrontPizza.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\_Imports.razor"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Account\Account.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/account")]
    public partial class Account : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Account\Account.razor"
 if (customer == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "\"");
            __builder.AddContent(3, 
#nullable restore
#line 8 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Account\Account.razor"
         L["Downloads"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, "...\"");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 9 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Account\Account.razor"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Account\Account.razor"
     if (customer != null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "        ");
            __builder.OpenElement(7, "h3");
            __builder.AddContent(8, 
#nullable restore
#line 14 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Account\Account.razor"
             L["Account: "]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(9, " ");
            __builder.AddContent(10, 
#nullable restore
#line 14 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Account\Account.razor"
                             Username

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "p");
            __builder.OpenElement(13, "b");
            __builder.AddContent(14, 
#nullable restore
#line 15 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Account\Account.razor"
               L["Email"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(15, ": ");
            __builder.CloseElement();
            __builder.AddContent(16, 
#nullable restore
#line 15 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Account\Account.razor"
                                Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        <hr>\r\n        ");
            __builder.AddMarkupContent(18, @"<style>
            img {
                height: 150px;
                width: 150px;
                border-radius: 50%;
            }

            .headBlock {
                display: flex;
                align-items: center;
                width: auto;
            }

                .headBlock > h3 {
                    margin: 20px;
                    width: auto;
                }

            .dataBlock {
                background-color: rgb(248,248,248);
                padding: 10px;
                border-radius: 20px;
                width: auto;
            }
        </style>
        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "dataBlock");
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "headBlock");
            __builder.AddMarkupContent(24, "\r\n");
#nullable restore
#line 44 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Account\Account.razor"
                 if (base64string == null || string.IsNullOrEmpty(base64string) || customer.photo == null)
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(25, "                    <img src=\"/default_images/defaultUser.jpg\">\r\n");
#nullable restore
#line 47 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Account\Account.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(26, "                    ");
            __builder.OpenElement(27, "img");
            __builder.AddAttribute(28, "src", "data:image/jpeg;base64," + (
#nullable restore
#line 50 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Account\Account.razor"
                                                      base64string

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
#nullable restore
#line 51 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Account\Account.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenElement(31, "h3");
            __builder.AddContent(32, 
#nullable restore
#line 53 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Account\Account.razor"
                     Username

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n            <br>\r\n            ");
            __builder.OpenElement(35, "a");
            __builder.AddAttribute(36, "href", "/account/photo");
            __builder.AddAttribute(37, "class", "btn btn-sm btn-primary");
            __builder.AddContent(38, 
#nullable restore
#line 56 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Account\Account.razor"
                                                                     L["Change photo"]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n            <br>\r\n            <br>\r\n            <hr>\r\n\r\n            ");
            __builder.OpenElement(40, "h4");
            __builder.AddContent(41, 
#nullable restore
#line 61 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Account\Account.razor"
                 L["Personal information"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(42, " :");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n            ");
            __builder.OpenElement(44, "p");
            __builder.OpenElement(45, "b");
            __builder.AddContent(46, 
#nullable restore
#line 62 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Account\Account.razor"
                   L["Last name"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(47, ": ");
            __builder.CloseElement();
            __builder.AddContent(48, 
#nullable restore
#line 62 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Account\Account.razor"
                                        customer.lastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n            ");
            __builder.OpenElement(50, "p");
            __builder.OpenElement(51, "b");
            __builder.AddContent(52, 
#nullable restore
#line 63 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Account\Account.razor"
                   L["First name"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(53, ": ");
            __builder.CloseElement();
            __builder.AddContent(54, 
#nullable restore
#line 63 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Account\Account.razor"
                                         customer.firstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n            ");
            __builder.OpenElement(56, "p");
            __builder.OpenElement(57, "b");
            __builder.AddContent(58, 
#nullable restore
#line 64 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Account\Account.razor"
                   L["Second name"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(59, ": ");
            __builder.CloseElement();
            __builder.AddContent(60, 
#nullable restore
#line 64 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Account\Account.razor"
                                          customer.secondName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n            ");
            __builder.OpenElement(62, "p");
            __builder.OpenElement(63, "b");
            __builder.AddContent(64, 
#nullable restore
#line 65 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Account\Account.razor"
                   L["Address"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(65, ": ");
            __builder.CloseElement();
            __builder.AddContent(66, 
#nullable restore
#line 65 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Account\Account.razor"
                                      customer.adress

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n            ");
            __builder.OpenElement(68, "p");
            __builder.OpenElement(69, "b");
            __builder.AddContent(70, 
#nullable restore
#line 66 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Account\Account.razor"
                   L["Phone number"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(71, ": ");
            __builder.CloseElement();
            __builder.AddContent(72, 
#nullable restore
#line 66 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Account\Account.razor"
                                           customer.phoneNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n            ");
            __builder.OpenElement(74, "a");
            __builder.AddAttribute(75, "class", "btn btn-primary");
            __builder.AddAttribute(76, "href", "/account/inputData");
            __builder.AddContent(77, 
#nullable restore
#line 67 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Account\Account.razor"
                                                                  L["Enter information about yourself"]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n            <br>\r\n            <br>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n");
#nullable restore
#line 71 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Account\Account.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Account\Account.razor"
         
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Account\Account.razor"
           
        CustomerViewModel customer { get; set; } = new CustomerViewModel();
        string Username { get; set; }
        string Email { get; set; }
        string base64string = null;
protected override async Task OnInitializedAsync()
    {
        var authState = await authentificationStateProvider.GetAuthenticationStateAsync();
        var customerId = authState.User.Claims.First(x => x.Type == "customerId").Value;
        Username = authState.User.Identity.Name;
        Email = authState.User.Claims.First(x => x.Type == "email").Value;
        customer = await customerService.GetCustomerByIdAsync(Int32.Parse(customerId));
        base64string = Convert.ToBase64String(customer.photo);
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStringLocalizer<Account> L { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authentificationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FrontPizza.Data.CustomerService customerService { get; set; }
    }
}
#pragma warning restore 1591
