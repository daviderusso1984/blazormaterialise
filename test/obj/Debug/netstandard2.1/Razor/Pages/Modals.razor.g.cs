#pragma checksum "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Pages/Modals.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f50b443db383923da830506c33640a8a93d44d3a"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Modal")]
    public partial class Modals : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Modal</h3>\n\n");
            __builder.OpenComponent<blazormaterialise.BM_button>(1);
            __builder.AddAttribute(2, "Data_target", "model1");
            __builder.AddAttribute(3, "Class", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 5 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Pages/Modals.razor"
                                        blazormaterialise.Opz.Modal_trigger

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(5, "Click");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\n\n");
            __builder.OpenComponent<blazormaterialise.BM_modal>(7);
            __builder.AddAttribute(8, "Id", "model1");
            __builder.AddAttribute(9, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.AddMarkupContent(11, "<h4>Modal Header</h4>\r\n        ");
                __builder2.AddMarkupContent(12, "<p>A bunch of text</p>\r\n    ");
            }
            ));
            __builder.AddAttribute(13, "Footer", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(14, "\r\n        ");
                __builder2.OpenComponent<blazormaterialise.BM_button>(15);
                __builder2.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(17, "I Gree");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591