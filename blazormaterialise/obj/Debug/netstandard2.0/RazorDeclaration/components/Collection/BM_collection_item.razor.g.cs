#pragma checksum "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/Components/Collection/BM_collection_item.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0c93d3241b4cdd49226b8d416a89f1d69961b4b"
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
    public partial class BM_collection_item : css_base
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 18 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/Components/Collection/BM_collection_item.razor"
      
    [Parameter]
    public RenderFragment ChildContent{get;set;}

    [Parameter]
    public enum_collection Type_item {get;set;} = enum_collection.Links;
    [Parameter]
    public string Href {get;set;} = "";
    [Parameter]
    public bool Active{get;set;} = false;

    private string valor = "";

    private string dim="";

    protected override void OnInitialized(){
        dim = "";
        dim += blazormaterialise.show.get_show(Visibility) + " ";
      dim += color.get_backcolor(color.get_color(Backcolor)) + " ";
        dim += color.get_Textcolor(color.get_color(Textcolor)) + " ";
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
