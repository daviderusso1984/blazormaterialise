#pragma checksum "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\Components\BM_badge.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83e2fcaa53c75e96e94ed388e2968f798646eeca"
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
    public partial class BM_badge : css_base
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 10 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\Components\BM_badge.razor"
      

    [Parameter]
    public bool New{get;set;} = false;
    [Parameter]
    public string Text{get;set;} = "";

    private string valor = "";

    private string dim="";

    protected override void OnInitialized(){       
        if(New){
            valor += "new ";
        }
        dim = "";
         dim += blazormaterialise.show.get_show(Visibility) + " ";
       dim += color.get_backcolor(color.get_color(Backcolor)) + " ";
        dim += color.get_Textcolor(color.get_color(Textcolor)) + " ";
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
