#pragma checksum "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/css/BM_row.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7138a82c5011889becb06d29fee1d39731ef14c6"
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
    public partial class BM_row : grid_base
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row" + " " + (
#line 6 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/css/BM_row.razor"
                 Class

#line default
#line hidden
            ));
            __builder.AddMarkupContent(2, "\n    ");
            __builder.AddContent(3, 
#line 7 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/css/BM_row.razor"
     ChildContent

#line default
#line hidden
            );
            __builder.AddMarkupContent(4, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 11 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/css/BM_row.razor"
      
    [Parameter]
    public RenderFragment ChildContent { get; set; }

#line default
#line hidden
    }
}
#pragma warning restore 1591