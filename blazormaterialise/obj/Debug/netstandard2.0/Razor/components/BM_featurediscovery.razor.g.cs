#pragma checksum "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/Components/BM_featurediscovery.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b49107cb690debbfc060ef3622f8f2775175cd65"
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
    public partial class BM_featurediscovery : js_base
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "tap-target" + " " + (
#line 6 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/Components/BM_featurediscovery.razor"
                        Class

#line default
#line hidden
            ));
            __builder.AddAttribute(2, "data-target", 
#line 6 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/Components/BM_featurediscovery.razor"
                                             Data_target

#line default
#line hidden
            );
            __builder.AddAttribute(3, "id", 
#line 6 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/Components/BM_featurediscovery.razor"
                                                               Id

#line default
#line hidden
            );
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "tap-target-content" + " " + (
#line 7 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/Components/BM_featurediscovery.razor"
                                    dim

#line default
#line hidden
            ));
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddContent(8, 
#line 8 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/Components/BM_featurediscovery.razor"
         ChildContent

#line default
#line hidden
            );
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 12 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/Components/BM_featurediscovery.razor"
      
    [Parameter]
    public RenderFragment ChildContent { get; set; }

    private string dim = "";

    protected override void OnInitialized()
    {
        dim = "";
        dim += blazormaterialise.show.get_show(Visibility) + " ";
        dim += color.get_backcolor(color.get_color(Backcolor)) + " ";
        dim += color.get_Textcolor(color.get_color(Textcolor)) + " ";
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await base.OnAfterRenderAsync(firstRender);
        if (firstRender)
        {
            await JSRuntime.InvokeVoidAsync("featurediscovery_init");
        }

    }

    public async void close()
    {        
        await JSRuntime.InvokeVoidAsync("featurediscovery_close", Id);
    }

    public async void show()
    {
        await JSRuntime.InvokeVoidAsync("featurediscovery_show",Id);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
