#pragma checksum "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/BM_navbar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d75a1efbd63a38af5a620b650e6ed7f807f8c42"
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
    public partial class BM_navbar : css_base
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 25 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/BM_navbar.razor"
      
    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Parameter]
    public bool Fixed { get; set; } = false;

    private string show = "";

    protected override async Task OnAfterRenderAsync (bool firstRender) {
        await base.OnAfterRenderAsync (firstRender);
        await JSRuntime.InvokeVoidAsync ("navbar_init");
        var sh = new show ();
        show = sh.get_show (Visibility);
    }


#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591