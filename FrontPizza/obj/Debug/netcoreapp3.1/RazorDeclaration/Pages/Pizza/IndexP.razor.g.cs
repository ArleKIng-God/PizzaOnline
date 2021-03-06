#pragma checksum "C:\Users\Василь\Desktop\aaaa\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "caa0f39c709610cf3ab194f44d3b161b3228499c"
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
#line 1 "C:\Users\Василь\Desktop\aaaa\PizzaOnline\FrontPizza\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Василь\Desktop\aaaa\PizzaOnline\FrontPizza\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Василь\Desktop\aaaa\PizzaOnline\FrontPizza\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Василь\Desktop\aaaa\PizzaOnline\FrontPizza\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Василь\Desktop\aaaa\PizzaOnline\FrontPizza\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Василь\Desktop\aaaa\PizzaOnline\FrontPizza\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Василь\Desktop\aaaa\PizzaOnline\FrontPizza\_Imports.razor"
using FrontPizza;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Василь\Desktop\aaaa\PizzaOnline\FrontPizza\_Imports.razor"
using FrontPizza.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Василь\Desktop\aaaa\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
using FrontPizza.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Василь\Desktop\aaaa\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
using PizzaOnline.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Василь\Desktop\aaaa\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Василь\Desktop\aaaa\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
using FrontPizza.Validation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Василь\Desktop\aaaa\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/pizza")]
    public partial class IndexP : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "C:\Users\Василь\Desktop\aaaa\PizzaOnline\FrontPizza\Pages\Pizza\IndexP.razor"
       
    public PizzaViewModel pizzaViewModels = new PizzaViewModel();
    public List<PizzaViewModel> pizza;
    private int pageNum = 1;
    private int pageSize = 2;
    protected override async Task OnInitializedAsync()
    {
        pizzaViewModels = new PizzaViewModel();
        pizza = await pizzaService.GetPizzaAsync(new PizzaQueryParameters { PageSize = pageSize, PageNumber = pageNum });
    }
    public async Task NextPage()
    {
        pageNum++;
        pizza = await pizzaService.GetPizzaAsync(new PizzaQueryParameters { PageNumber = pageNum, PageSize = pageSize });
    }
    public async Task PrevPage()
    {
        if (pageNum > 1)
        {
            pageNum--;
            pizza = await pizzaService.GetPizzaAsync(new PizzaQueryParameters { PageNumber = pageNum, PageSize = pageSize });
        }
    }
    private async Task<bool> SavePizza()
    {
        var returnedPizza = await pizzaService.SavePizza(pizzaViewModels);
        pizza = await pizzaService.GetPizzaAsync(new PizzaQueryParameters { PageSize = pageSize, PageNumber = pageNum });
        return await Task.FromResult(true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.PizzaService pizzaService { get; set; }
    }
}
#pragma warning restore 1591
