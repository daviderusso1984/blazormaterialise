#pragma checksum "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/compo/BM_navbar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "970cfab57c8a17823ffa3fa2b2bdfce8dc1c25d2"
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
    public partial class BM_navbar : css_base
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 5 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/compo/BM_navbar.razor"
     if(Fixed){

#line default
#line hidden
            __builder.AddContent(0, "        ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "navbar-fixed" + " " + (
#line 6 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/compo/BM_navbar.razor"
                                  Class

#line default
#line hidden
            ) + " " + (
#line 6 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/compo/BM_navbar.razor"
                                         show

#line default
#line hidden
            ) + " ");
            __builder.AddMarkupContent(3, "\n            ");
            __builder.OpenElement(4, "nav");
            __builder.AddMarkupContent(5, "\n                ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "nav-wrapper");
            __builder.AddMarkupContent(8, "\n                ");
            __builder.AddContent(9, 
#line 9 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/compo/BM_navbar.razor"
                 ChildContent

#line default
#line hidden
            );
            __builder.AddMarkupContent(10, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n");
#line 13 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/compo/BM_navbar.razor"
    }else{

#line default
#line hidden
            __builder.AddContent(14, "        ");
            __builder.OpenElement(15, "nav");
            __builder.AddAttribute(16, "class", (
#line 14 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/compo/BM_navbar.razor"
                     Class

#line default
#line hidden
            ) + " " + (
#line 14 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/compo/BM_navbar.razor"
                            show

#line default
#line hidden
            ) + " " + (
#line 14 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/compo/BM_navbar.razor"
                                  Backcolor

#line default
#line hidden
            ) + " " + (
#line 14 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/compo/BM_navbar.razor"
                                             Textcolor

#line default
#line hidden
            ));
            __builder.AddMarkupContent(17, "\n            ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "nav-wrapper");
            __builder.AddMarkupContent(20, "\n            ");
            __builder.AddContent(21, 
#line 16 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/compo/BM_navbar.razor"
             ChildContent

#line default
#line hidden
            );
            __builder.AddMarkupContent(22, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n");
#line 19 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/compo/BM_navbar.razor"
    }

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 25 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/compo/BM_navbar.razor"
      
    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Parameter]
    public bool Fixed { get; set; } = false;

    private string show = "";

    protected override void OnInitialized(){
        show = blazormaterialise.show.get_show(Visibility);
       
    }

    protected override async Task OnAfterRenderAsync (bool firstRender) {
        await base.OnAfterRenderAsync (firstRender);
        await JSRuntime.InvokeVoidAsync ("navbar_init");
        
    }


#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591