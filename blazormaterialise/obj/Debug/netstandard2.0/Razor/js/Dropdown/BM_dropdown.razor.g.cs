#pragma checksum "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/js/Dropdown/BM_dropdown.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c671847b254d61916a86bfe2b06959162988abb"
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
    public partial class BM_dropdown : js_base
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "ul");
            __builder.AddAttribute(1, "id", 
#line 5 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/js/Dropdown/BM_dropdown.razor"
           Id

#line default
#line hidden
            );
            __builder.AddAttribute(2, "class", "dropdown-content" + " " + (
#line 5 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/js/Dropdown/BM_dropdown.razor"
                                        Class

#line default
#line hidden
            ) + " " + (
#line 5 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/js/Dropdown/BM_dropdown.razor"
                                               show

#line default
#line hidden
            ));
            __builder.AddMarkupContent(3, "\n   ");
            __builder.AddContent(4, 
#line 6 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/js/Dropdown/BM_dropdown.razor"
    ChildContent

#line default
#line hidden
            );
            __builder.AddMarkupContent(5, "\n  ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 9 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/js/Dropdown/BM_dropdown.razor"
        

      [Parameter]
    public RenderFragment ChildContent { get; set; }
       private string show="";
    

    protected override async Task OnAfterRenderAsync(bool firstRender){
        await base.OnAfterRenderAsync(firstRender);
        await JSRuntime.InvokeVoidAsync("dropdown_init");
        var sh = new show();
        show = sh.get_show(Visibility);
    }

  

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
