#pragma checksum "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\Components\Carousel\BM_carousel.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2e45ce67b310b2a669e2568fb8f00bb8683f8eb"
// <auto-generated/>
#pragma warning disable 1591
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
    public partial class BM_carousel : js_base
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "carousel" + " " + (
#line 8 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\Components\Carousel\BM_carousel.razor"
                      dim

#line default
#line hidden
            ) + " " + (
#line 8 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\Components\Carousel\BM_carousel.razor"
                           Class

#line default
#line hidden
            ) + " ");
            __builder.AddAttribute(2, "id", 
#line 8 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\Components\Carousel\BM_carousel.razor"
                                        Id

#line default
#line hidden
            );
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddContent(4, 
#line 9 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\Components\Carousel\BM_carousel.razor"
     ChildContent

#line default
#line hidden
            );
            __builder.AddMarkupContent(5, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 13 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\Components\Carousel\BM_carousel.razor"
      
    [Parameter]
    public RenderFragment ChildContent { get; set; }

     private string dim ="";

     protected override void OnInitialized(){
        dim = "";
        dim += blazormaterialise.show.get_show(Visibility) + " ";
       dim += color.get_backcolor(color.get_color(Backcolor)) + " ";
        dim += color.get_Textcolor(color.get_color(Textcolor)) + " ";
     }
    

    protected override async Task OnAfterRenderAsync(bool firstRender){
        await base.OnAfterRenderAsync(firstRender);
        if(firstRender){
             await JSRuntime.InvokeVoidAsync("bm_carousel",Id);
        }       
    }


#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
