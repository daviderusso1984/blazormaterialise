#pragma checksum "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Pages/Slider.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a6888658fb6230bbfd96e90427cbe61e6d49716"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Slider")]
    public partial class Slider : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Slider</h3>\n\n");
            __builder.OpenComponent<blazormaterialise.BM_slider>(1);
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    ");
                __builder2.OpenComponent<blazormaterialise.BM_slider_item>(4);
                __builder2.AddAttribute(5, "Src", "https://lorempixel.com/800/400/nature/3");
                __builder2.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(7, "\r\n        ");
                    __builder3.AddMarkupContent(8, "<h3>Title One</h3>\r\n        ");
                    __builder3.AddMarkupContent(9, "<p>Content nature image 1</p>\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n    ");
                __builder2.OpenComponent<blazormaterialise.BM_slider_item>(11);
                __builder2.AddAttribute(12, "Src", "https://lorempixel.com/800/400/nature/4");
                __builder2.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(14, "\r\n        ");
                    __builder3.AddMarkupContent(15, "<h3>Title Two</h3>\r\n        ");
                    __builder3.AddMarkupContent(16, "<p>Content nature image 2</p>\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n    ");
                __builder2.OpenComponent<blazormaterialise.BM_slider_item>(18);
                __builder2.AddAttribute(19, "Src", "https://lorempixel.com/800/400/nature/3");
                __builder2.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(21, "\r\n        ");
                    __builder3.AddMarkupContent(22, "<h3>Title Three</h3>\r\n        ");
                    __builder3.AddMarkupContent(23, "<p>Content nature image 3</p>\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n    ");
                __builder2.OpenComponent<blazormaterialise.BM_slider_item>(25);
                __builder2.AddAttribute(26, "Src", "https://lorempixel.com/800/400/nature/4");
                __builder2.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(28, "\r\n        ");
                    __builder3.AddMarkupContent(29, "<h3>Title Four</h3>\r\n        ");
                    __builder3.AddMarkupContent(30, "<p>Content nature image 4</p>\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(32, "\r\n\r\n");
            __builder.OpenComponent<test.Pages.Code>(33);
            __builder.AddAttribute(34, "rows", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String[]>(
#nullable restore
#line 25 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Pages/Slider.razor"
            rows_1

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Pages/Slider.razor"
      

 

    private string[] rows_1 = new string[]
    {
        "<BM_slider>",
        "\r\n<BM_slider_item Src=\"https://lorempixel.com/800/400/nature/3\">",
        "\r\n\r\n<h3>Title One</h3>",
        "\r\n\r\n<p>Content nature image 1</p>",
        "\r\n</BM_slider_item>",

        "\r\n<BM_slider_item Src=\"https://lorempixel.com/800/400/nature/4\">",
        "\r\n\r\n<h3>Title Two</h3>",
        "\r\n\r\n<p>Content nature image 2</p>",
        "\r\n</BM_slider_item>",

        "\r\n<BM_slider_item Src=\"https://lorempixel.com/800/400/nature/3\">",
        "\r\n\r\n<h3>Title Three</h3>",
        "\r\n\r\n<p>Content nature image 3</p>",
        "\r\n</BM_slider_item>",

        "\r\n<BM_slider_item Src=\"https://lorempixel.com/800/400/nature/4\">",
        "\r\n\r\n<h3>Title Four</h3>",
        "\r\n\r\n<p>Content nature image 4</p>",
        "\r\n</BM_slider_item>"

};

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
