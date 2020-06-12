#pragma checksum "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaId.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4b64aec9098cef96594275a749af1e66ada08b8"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FrontPizza.Pages.Pizza
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
#line 1 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaId.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaId.razor"
using FrontPizza.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaId.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/pizza/{id}")]
    public partial class PizzaId : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 132 "C:\Users\Василь\Desktop\Pizzza\PizzaOnline\FrontPizza\Pages\Pizza\PizzaId.razor"
       
    PizzaViewModel pizza;
    IngradientsViewModel ingradients;
    string image;
    [Parameter]
    public string Id { get; set; }

    protected override async Task OnInitializedAsync()
    {
        pizza = await pizzaService.GetPizzaById(Convert.ToInt32(Id));
        image = pizza.image;
        ingradients = await ingredientService.GetByIdIngredients(pizza.ingredientsId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStringLocalizer<PizzaId> L { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.IngrefientsService ingredientService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.PizzaService pizzaService { get; set; }
    }
}
#pragma warning restore 1591
