#pragma checksum "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/css/BM_container.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d0c7e4d6d669a69878bd44258e54adcef26bbf8"
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
    public partial class BM_container : grid_base
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container" + " " + (
#line 6 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/css/BM_container.razor"
                       Class

#line default
#line hidden
            ) + " " + (
#line 6 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/css/BM_container.razor"
                              dim

#line default
#line hidden
            ));
            __builder.AddMarkupContent(2, "\n    ");
            __builder.AddContent(3, 
#line 7 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/css/BM_container.razor"
     ChildContent

#line default
#line hidden
            );
            __builder.AddMarkupContent(4, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 11 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/css/BM_container.razor"
      
    [Parameter]
    public RenderFragment ChildContent { get; set; }

     private string dim = "";

     protected override void OnInitialized(){
         dim += color.get_backcolor(color.get_color(Backcolor)) + " "; 
        dim += color.get_Textcolor(color.get_color(Textcolor)) + " ";


    }



#line default
#line hidden
    }
}
#pragma warning restore 1591
