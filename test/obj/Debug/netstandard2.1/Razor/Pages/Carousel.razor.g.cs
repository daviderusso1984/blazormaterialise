#pragma checksum "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\test\Pages\Carousel.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba2dc8b18af0bdbaab4dbbc03f45142e6cce5001"
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
#line 1 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\test\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\test\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\test\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\test\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\test\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\test\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\test\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\test\_Imports.razor"
using test;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\test\_Imports.razor"
using test.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\test\_Imports.razor"
using blazormaterialise;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Carousel")]
    public partial class Carousel : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class>Carousel</h3>\r\n\r\n");
            __builder.OpenComponent<blazormaterialise.BM_carousel>(1);
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    ");
                __builder2.OpenComponent<blazormaterialise.BM_carousel_item>(4);
                __builder2.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(6, "<img src=\"https://lorempixel.com/250/250/nature/1\">");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<blazormaterialise.BM_carousel_item>(8);
                __builder2.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(10, "<img src=\"https://lorempixel.com/250/250/nature/2\">");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n    ");
                __builder2.OpenComponent<blazormaterialise.BM_carousel_item>(12);
                __builder2.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(14, "<img src=\"https://lorempixel.com/250/250/nature/3\">");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n    ");
                __builder2.OpenComponent<blazormaterialise.BM_carousel_item>(16);
                __builder2.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(18, "<img src=\"https://lorempixel.com/250/250/nature/4\">");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n   \r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
