#pragma checksum "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/css/BM_col.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35aa20d67e7aae175b43cf5530aa663a1ea20b39"
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
    public partial class BM_col : grid_base
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col" + " " + (
#line 8 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/css/BM_col.razor"
                 dim

#line default
#line hidden
            ) + " " + (
#line 8 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/css/BM_col.razor"
                      Class

#line default
#line hidden
            ));
            __builder.AddMarkupContent(2, "\n    ");
            __builder.AddContent(3, 
#line 9 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/css/BM_col.razor"
     ChildContent

#line default
#line hidden
            );
            __builder.AddMarkupContent(4, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 13 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/css/BM_col.razor"
      
    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Parameter]
    public int S {get;set;} = 0;

    [Parameter]
    public int M {get;set;}  = 0;

    [Parameter]
    public int L {get;set;}  = 0;

    [Parameter]
    public int XL {get;set;}  =0;

    private string dim = "";

    protected override void OnInitialized(){
        
        if(S != 0 && S > 0 && S <= 12){
            dim += "s" + S.ToString() + " ";
        }
        if(M != 0 && M > 0 && M <= 12){
            dim += "m" + M.ToString() + " ";
        }  
        if(L != 0 && L > 0 && L <= 12){
            dim += "l" + L.ToString() + " ";
        }    
        if(XL != 0 && XL > 0 && XL <= 12){
            dim += "xl" + XL.ToString() + " ";
        }  
        dim += color.get_backcolor(color.get_color(Backcolor)) + " "; 
        dim += color.get_Textcolor(color.get_color(Textcolor)) + " ";


    }

  


#line default
#line hidden
    }
}
#pragma warning restore 1591
