#pragma checksum "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/Components/BM_media.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b219d0b5574bd5ff5a1b8e979a5d3f367d6b48c"
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
    public partial class BM_media : js_base
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 5 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/Components/BM_media.razor"
 if (Caption)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "img");
            __builder.AddAttribute(2, "class", "materialboxed" + " " + (
#line 7 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/Components/BM_media.razor"
                               dim

#line default
#line hidden
            ) + " " + (
#line 7 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/Components/BM_media.razor"
                                    Class

#line default
#line hidden
            ) + " ");
            __builder.AddAttribute(3, "id", 
#line 7 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/Components/BM_media.razor"
                                                 Id

#line default
#line hidden
            );
            __builder.AddAttribute(4, "data-caption", 
#line 7 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/Components/BM_media.razor"
                                                                    Data_caption

#line default
#line hidden
            );
            __builder.AddAttribute(5, "src", 
#line 7 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/Components/BM_media.razor"
                                                                                        Src

#line default
#line hidden
            );
            __builder.AddAttribute(6, "width", 
#line 7 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/Components/BM_media.razor"
                                                                                                     Width

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
#line 8 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/Components/BM_media.razor"
}
else
{

#line default
#line hidden
            __builder.AddContent(8, "    ");
            __builder.OpenElement(9, "img");
            __builder.AddAttribute(10, "class", "materialboxed" + " " + (
#line 11 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/Components/BM_media.razor"
                               dim

#line default
#line hidden
            ) + " " + (
#line 11 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/Components/BM_media.razor"
                                    Class

#line default
#line hidden
            ) + " ");
            __builder.AddAttribute(11, "id", 
#line 11 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/Components/BM_media.razor"
                                                 Id

#line default
#line hidden
            );
            __builder.AddAttribute(12, "src", 
#line 11 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/Components/BM_media.razor"
                                                           Src

#line default
#line hidden
            );
            __builder.AddAttribute(13, "width", 
#line 11 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/Components/BM_media.razor"
                                                                        Width

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
#line 12 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/Components/BM_media.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 19 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/Components/BM_media.razor"
      
    [Parameter]
    public string Src { get; set; } = "";
    [Parameter]
    public string Width { get; set; } = "";
    [Parameter]
    public bool Caption { get; set; } = false;
    [Parameter]
    public bool Responsive { get; set; } = false;
    [Parameter]
    public string Data_caption { get; set; } = "";

    private string dim = "";


    protected override void OnInitialized()
    {
        dim = "";
        if (Responsive)
        {
            dim += "responsive-img ";
        }
        dim += blazormaterialise.show.get_show(Visibility) + " ";
         dim += color.get_backcolor(color.get_color(Backcolor)) + " ";
        dim += color.get_Textcolor(color.get_color(Textcolor)) + " ";
    }


    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await base.OnAfterRenderAsync(firstRender);
        if (firstRender)
        {
            await JSRuntime.InvokeVoidAsync("bm_media", Id);
        }


    }




#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591