#pragma checksum "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/BM_floating_action_button.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3078d83c67f152190deebe5bca27b58e420d3e88"
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
#line 1 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 2 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 3 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
    public partial class BM_floating_action_button : css_base
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "fixed-action-btn" + " " + (
#line 7 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/BM_floating_action_button.razor"
                              Class

#line default
#line hidden
            ) + " " + (
#line 7 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/BM_floating_action_button.razor"
                                     show

#line default
#line hidden
            ));
            __builder.AddMarkupContent(2, "\n  ");
            __builder.OpenElement(3, "a");
            __builder.AddAttribute(4, "class", "btn-floating" + " btn-large" + " " + (
#line 8 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/BM_floating_action_button.razor"
                                    Backcolor

#line default
#line hidden
            ));
            __builder.AddMarkupContent(5, "\n    ");
            __builder.OpenElement(6, "i");
            __builder.AddAttribute(7, "class", "large material-icons");
            __builder.AddContent(8, 
#line 9 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/BM_floating_action_button.razor"
                                     Icon

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n  ");
            __builder.OpenElement(11, "ul");
            __builder.AddMarkupContent(12, "\n");
#line 12 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/BM_floating_action_button.razor"
       if(Items_floating != null){
          

#line default
#line hidden
#line 13 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/BM_floating_action_button.razor"
           foreach (var item in Items_floating)
          {

#line default
#line hidden
            __builder.AddContent(13, "              ");
            __builder.OpenElement(14, "li");
            __builder.OpenElement(15, "a");
            __builder.AddAttribute(16, "class", "btn-floating" + " " + (
#line 15 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/BM_floating_action_button.razor"
                                          item.color

#line default
#line hidden
            ));
            __builder.AddAttribute(17, "href", 
#line 15 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/BM_floating_action_button.razor"
                                                             item.href

#line default
#line hidden
            );
            __builder.OpenElement(18, "i");
            __builder.AddAttribute(19, "class", "material-icons");
            __builder.AddContent(20, 
#line 15 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/BM_floating_action_button.razor"
                                                                                                   item.icon

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n");
#line 16 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/BM_floating_action_button.razor"
          }

#line default
#line hidden
#line 16 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/BM_floating_action_button.razor"
           
      }   

#line default
#line hidden
            __builder.AddContent(22, "  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 21 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/BM_floating_action_button.razor"
      
    [Parameter]
    public string Icon{get;set;}
    [Parameter]
    public structure_floating[] Items_floating{get;set;}

     private string show="";

    protected override async Task OnAfterRenderAsync(bool firstRender){
        await base.OnAfterRenderAsync(firstRender);
        await JSRuntime.InvokeVoidAsync("floating_init");
       
    }

    


#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
