#pragma checksum "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/BM_footer_copyright.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7f116d42ddbbe5ab84c0d256fbb7baab1dc9aa3"
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
    public partial class BM_footer_copyright : css_base
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "footer");
            __builder.AddAttribute(1, "class", "footer-copyright" + " " + (
#line 5 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/BM_footer_copyright.razor"
                                 Class

#line default
#line hidden
            ) + " " + (
#line 5 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/BM_footer_copyright.razor"
                                        show

#line default
#line hidden
            ) + " " + (
#line 5 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/BM_footer_copyright.razor"
                                              Backcolor

#line default
#line hidden
            ) + " " + (
#line 5 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/BM_footer_copyright.razor"
                                                         Textcolor

#line default
#line hidden
            ));
            __builder.AddMarkupContent(2, "\n    ");
            __builder.AddContent(3, 
#line 6 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/BM_footer_copyright.razor"
     ChildContent

#line default
#line hidden
            );
            __builder.AddMarkupContent(4, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 12 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/BM_footer_copyright.razor"
      
    [Parameter]
    public RenderFragment ChildContent{get;set;}

    private string show;

     protected override void OnInitialized(){
       
        
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
