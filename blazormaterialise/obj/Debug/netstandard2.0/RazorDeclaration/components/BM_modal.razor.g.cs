#pragma checksum "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\Components\BM_modal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bc88af87da12ed9caaaa7db77d304ed76f4b9fb"
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
#line 1 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 2 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 3 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
    public partial class BM_modal : js_base
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 16 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\Components\BM_modal.razor"
      
    [Parameter]
    public RenderFragment Content { get; set; }
    [Parameter]
    public RenderFragment Footer { get; set; }


    private string dim = "";

    protected override void OnInitialized()
    {

        dim = "";
        dim += blazormaterialise.show.get_show(Visibility) + " ";
        dim += color.get_backcolor(color.get_color(Backcolor)) + " ";
        dim += color.get_Textcolor(color.get_color(Textcolor)) + " ";

    }

    protected override async Task OnAfterRenderAsync (bool firstRender) {
        await base.OnAfterRenderAsync (firstRender);
        if (firstRender)
        {
            await JSRuntime.InvokeVoidAsync("modal_init");
        }
    }

    public async void open()
    {
        await JSRuntime.InvokeVoidAsync("modal_open",Id);
    }

    public async void close()
    {
        await JSRuntime.InvokeVoidAsync("modal_close",Id);
    }


#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
