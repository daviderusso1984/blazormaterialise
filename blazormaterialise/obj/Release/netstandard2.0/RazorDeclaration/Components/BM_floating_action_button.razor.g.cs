#pragma checksum "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\Components\BM_floating_action_button.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e05c0826f6e104e90a16a9760d8a2ca2dc4f5dbb"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace blazormaterialise
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 2 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 3 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
    public partial class BM_floating_action_button : css_base
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 21 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\Components\BM_floating_action_button.razor"
      
    [Parameter]
    public string Icon{get;set;}
    [Parameter]
    public structure_floating[] Items_floating{get;set;}

    private string dim="";

    protected override void OnInitialized()
    {
        base.OnInitialized();
        dim = "";
        dim += blazormaterialise.show.get_show(Visibility) + " ";
        dim += color.get_backcolor(color.get_color(Backcolor)) + " ";
        dim += color.get_Textcolor(color.get_color(Textcolor)) + " ";
    }

    protected override async Task OnAfterRenderAsync(bool firstRender){
        await base.OnAfterRenderAsync(firstRender);
        await JSRuntime.InvokeVoidAsync("bm_floating",Id);

    }




#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
