#pragma checksum "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfe822bc33fb9f743ae82b0de10dd137187bc558"
// <auto-generated/>
#pragma warning disable 1591
namespace test.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/_Imports.razor"
using test;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/_Imports.razor"
using test.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/_Imports.razor"
using blazormaterialise;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<blazormaterialise.BM_text_input>(0);
            __builder.AddAttribute(1, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 5 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Pages/Index.razor"
                             text

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => text = __value, text))));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenElement(4, "p");
            __builder.AddContent(5, 
#nullable restore
#line 6 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Pages/Index.razor"
    text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.OpenComponent<blazormaterialise.BM_checkbox>(7);
            __builder.AddAttribute(8, "Title", "Mio");
            __builder.AddAttribute(9, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 7 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Pages/Index.razor"
                           mio

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => mio = __value, mio))));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.OpenElement(12, "p");
            __builder.AddContent(13, 
#nullable restore
#line 8 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Pages/Index.razor"
    mio

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Pages/Index.razor"
      
    private string text="";

    private bool mio = false;

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
