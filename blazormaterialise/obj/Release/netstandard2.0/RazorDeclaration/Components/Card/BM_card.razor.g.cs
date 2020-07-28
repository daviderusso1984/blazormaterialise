#pragma checksum "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/Components/Card/BM_card.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d35798d44eda3d3e08263d1c79679dbcd0fc0b0"
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
    public partial class BM_card : css_base
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 21 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/Components/Card/BM_card.razor"
       

    [Parameter]
    public RenderFragment ChildContent { get; set; }
    [Parameter]
    public bool Horizontal { get; set; } = false;
    [Parameter]
    public enum_card_size Card_size { get; set; } = enum_card_size.not;
    [Parameter]
    public bool Pannel { get; set; } = false;

    private string dim = "";

    protected override void OnInitialized()
    {
        dim ="";
        dim += blazormaterialise.show.get_show(Visibility) + " ";
        dim += color.get_backcolor(color.get_color(Backcolor)) + " ";
        dim += color.get_Textcolor(color.get_color(Textcolor)) + " ";
        if (Horizontal)
        {
            dim += "horizontal ";
        }
        dim += get_size(Card_size);
    }

    private string get_size(enum_card_size si)
    {
        switch (si)
        {
            case enum_card_size.not:
                return "";
            case enum_card_size.medium:
                return "medium";
            case enum_card_size.large:
                return "large";
            case enum_card_size.small:
                return "small";
            default:
                return "";
        }
    }


#line default
#line hidden
    }
}
#pragma warning restore 1591