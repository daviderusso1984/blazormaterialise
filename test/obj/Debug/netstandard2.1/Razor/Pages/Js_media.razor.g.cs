#pragma checksum "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\test\Pages\Js_media.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df1985079b62dd3b301f88182bd6c547112f6cf7"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Js_media")]
    public partial class Js_media : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Media</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<h5>Material Box</h5>\r\n\r\n");
            __builder.OpenComponent<blazormaterialise.BM_media>(2);
            __builder.AddAttribute(3, "Src", "https://lorempixel.com/800/400/nature/4");
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenComponent<test.Pages.Code>(5);
            __builder.AddAttribute(6, "rows", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String[]>(
#nullable restore
#line 10 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\test\Pages\Js_media.razor"
            rows_1

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.AddMarkupContent(8, "<h5>Material Box responsive</h5>\r\n\r\n");
            __builder.OpenComponent<blazormaterialise.BM_media>(9);
            __builder.AddAttribute(10, "Src", "https://lorempixel.com/800/400/nature/4");
            __builder.AddAttribute(11, "Responsive", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\test\Pages\Js_media.razor"
                                                                    true

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\r\n\r\n");
            __builder.OpenComponent<test.Pages.Code>(13);
            __builder.AddAttribute(14, "rows", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String[]>(
#nullable restore
#line 16 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\test\Pages\Js_media.razor"
            rows_2

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\r\n\r\n");
            __builder.AddMarkupContent(16, "<h5>Material Box data caption</h5>\r\n\r\n");
            __builder.OpenComponent<blazormaterialise.BM_media>(17);
            __builder.AddAttribute(18, "Src", "https://lorempixel.com/800/400/nature/4");
            __builder.AddAttribute(19, "Caption", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\test\Pages\Js_media.razor"
                                                                 true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "Data_caption", "Picture nature 4");
            __builder.CloseComponent();
            __builder.AddMarkupContent(21, "\r\n\r\n");
            __builder.OpenComponent<test.Pages.Code>(22);
            __builder.AddAttribute(23, "rows", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String[]>(
#nullable restore
#line 22 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\test\Pages\Js_media.razor"
            rows_3

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\test\Pages\Js_media.razor"
      

    private string[] rows_1 = new string[]
    {
        "<BM_media Src=\"https://lorempixel.com/800/400/nature/4\"  ></BM_media>"
    };

    private string[] rows_2 = new string[]
    {
        "<BM_media Src=\"https://lorempixel.com/800/400/nature/4\" Responsive=\"true\"></BM_media>"
    };

    private string[] rows_3 = new string[]
    {
        "<BM_media Src=\"https://lorempixel.com/800/400/nature/4\" Caption=\"true\" Data_caption=\"Picture nature 4\"></BM_media>"
    };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
