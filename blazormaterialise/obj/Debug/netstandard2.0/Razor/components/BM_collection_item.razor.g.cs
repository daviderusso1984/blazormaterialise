#pragma checksum "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/BM_collection_item.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c290173d3b846c3fa488ba81753f5d047520d3a1"
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
    public partial class BM_collection_item : css_base
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 6 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/BM_collection_item.razor"
 switch (Type_item)
{
    case enum_collection.Basic:

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "li");
            __builder.AddAttribute(2, "class", "collection-item");
            __builder.AddContent(3, 
#line 9 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/BM_collection_item.razor"
                                 ChildContent

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\n");
#line 10 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/BM_collection_item.razor"
    break;
    case enum_collection.Links:

#line default
#line hidden
            __builder.AddContent(5, "    ");
            __builder.OpenElement(6, "a");
            __builder.AddAttribute(7, "href", "#!");
            __builder.AddAttribute(8, "class", "collection-item" + " " + (
#line 12 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/BM_collection_item.razor"
                                         valor

#line default
#line hidden
            ));
            __builder.AddContent(9, 
#line 12 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/BM_collection_item.razor"
                                                 ChildContent

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n");
#line 13 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/BM_collection_item.razor"
    break;
    default:
    break;
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 18 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/BM_collection_item.razor"
      
    [Parameter]
    public RenderFragment ChildContent{get;set;}

    [Parameter]
    public enum_collection Type_item {get;set;}
    [Parameter]
    public bool Active{get;set;} = false;

    private string valor = "";

    private string show="";

    protected override void OnInitialized(){
        var sh = new show();
        show = sh.get_show(Visibility);
        if(Active){
            valor += "active ";
        }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591