#pragma checksum "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\test\Pages\Tabs.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e856b05ae7e57b92183bcee594417f4c726bcc8c"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Tabs")]
    public partial class Tabs : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    .bg {\r\n        width: 100%;\r\n        height: 100%;\r\n        min-height: 400px;\r\n        \r\n    }\r\n</style>\r\n\r\n");
            __builder.AddMarkupContent(1, "<h3>Tabs</h3>\r\n\r\n");
            __builder.AddMarkupContent(2, "<h5>Tabs Container ON</h5>\r\n\r\n");
            __builder.OpenComponent<blazormaterialise.BM_tab>(3);
            __builder.AddAttribute(4, "Container", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\test\Pages\Tabs.razor"
                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "Head", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(6, "\r\n        ");
                __builder2.AddMarkupContent(7, "<li class=\"tab col s3\"><a href=\"#test1\">Test 1</a></li>\r\n        ");
                __builder2.AddMarkupContent(8, "<li class=\"tab col s3\"><a class=\"active\" href=\"#test2\">Test 2</a></li>\r\n        ");
                __builder2.AddMarkupContent(9, "<li class=\"tab col s3 disabled\"><a href=\"#test3\">Disabled Tab</a></li>\r\n        ");
                __builder2.AddMarkupContent(10, "<li class=\"tab col s3\"><a href=\"#test4\">Test 4</a></li>\r\n    ");
            }
            ));
            __builder.AddAttribute(11, "Body", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(12, "\r\n        ");
                __builder2.AddMarkupContent(13, "<div id=\"test1\" class=\"col s12\">Test 1</div>\r\n        ");
                __builder2.AddMarkupContent(14, "<div id=\"test2\" class=\"col s12\">Test 2</div>\r\n        ");
                __builder2.AddMarkupContent(15, "<div id=\"test3\" class=\"col s12\">Test 3</div>\r\n        ");
                __builder2.AddMarkupContent(16, "<div id=\"test4\" class=\"col s12\">Test 4</div>\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(17, "\r\n\r\n");
            __builder.OpenComponent<test.Pages.Code>(18);
            __builder.AddAttribute(19, "rows", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String[]>(
#nullable restore
#line 32 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\test\Pages\Tabs.razor"
            text1

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(20, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(21, "<h5>Tabs Container OFF</h5>\r\n\r\n");
            __builder.OpenComponent<blazormaterialise.BM_tab>(22);
            __builder.AddAttribute(23, "Container", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 37 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\test\Pages\Tabs.razor"
                   false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "Head", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "\r\n        ");
                __builder2.AddMarkupContent(26, "<li class=\"tab col s3\"><a href=\"#test-swipe-1\">Test 1</a></li>\r\n        ");
                __builder2.AddMarkupContent(27, "<li class=\"tab col s3\"><a class=\"active\" href=\"#test-swipe-2\">Test 2</a></li>\r\n        ");
                __builder2.AddMarkupContent(28, "<li class=\"tab col s3\"><a href=\"#test-swipe-3\">Test 3</a></li>\r\n    ");
            }
            ));
            __builder.AddAttribute(29, "Body", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(30, "\r\n        ");
                __builder2.AddMarkupContent(31, "<div id=\"test-swipe-1\" class=\"col s12 blue bg\">Test 1</div>\r\n        ");
                __builder2.AddMarkupContent(32, "<div id=\"test-swipe-2\" class=\"col s12 red bg\">Test 2</div>\r\n        ");
                __builder2.AddMarkupContent(33, "<div id=\"test-swipe-3\" class=\"col s12 green bg\">Test 3</div>\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(34, "\r\n\r\n");
            __builder.OpenComponent<test.Pages.Code>(35);
            __builder.AddAttribute(36, "rows", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String[]>(
#nullable restore
#line 50 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\test\Pages\Tabs.razor"
            text2

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(37, "\r\n\r\n");
            __builder.AddMarkupContent(38, "<h5>Tabs Fixed Width</h5>\r\n\r\n");
            __builder.OpenComponent<blazormaterialise.BM_tab>(39);
            __builder.AddAttribute(40, "Container", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 54 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\test\Pages\Tabs.razor"
                   false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "Fixed_width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 54 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\test\Pages\Tabs.razor"
                                       true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "Head", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(43, "\r\n        ");
                __builder2.AddMarkupContent(44, "<li class=\"tab\"><a href=\"#test11\">Test 1</a></li>\r\n        ");
                __builder2.AddMarkupContent(45, "<li class=\"tab\"><a class=\"active\" href=\"#test12\">Test 2</a></li>\r\n        ");
                __builder2.AddMarkupContent(46, "<li class=\"tab disabled\"><a href=\"#test13\">Disabled Tab</a></li>\r\n        ");
                __builder2.AddMarkupContent(47, "<li class=\"tab\"><a href=\"#test14\">Test 4</a></li>\r\n        ");
                __builder2.AddMarkupContent(48, "<li class=\"tab\"><a href=\"#test15\">Test 5</a></li>\r\n    ");
            }
            ));
            __builder.AddAttribute(49, "Body", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(50, "\r\n        ");
                __builder2.AddMarkupContent(51, "<div id=\"test11\" class=\"col s12\"><p>Test 1</p></div>\r\n        ");
                __builder2.AddMarkupContent(52, "<div id=\"test12\" class=\"col s12\"><p>Test 2</p></div>\r\n        ");
                __builder2.AddMarkupContent(53, "<div id=\"test13\" class=\"col s12\"><p>Test 3</p></div>\r\n        ");
                __builder2.AddMarkupContent(54, "<div id=\"test14\" class=\"col s12\"><p>Test 4</p></div>\r\n        ");
                __builder2.AddMarkupContent(55, "<div id=\"test15\" class=\"col s12\"><p>Test 5</p></div>\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\test\Pages\Tabs.razor"
      

    private string[] text1 = new string[]
    {

"<BM_tab Container=\"true\">",
    "<Head>",
        "<li class=\"tab col s3\"><a href=\"#test1\">Test 1</a></li>",
        "<li class=\"tab col s3\"><a class=\"active\" href=\"#test2\">Test 2</a></li>",
        "<li class=\"tab col s3 disabled\"><a href=\"#test3\">Disabled Tab</a></li>",
        "<li class=\"tab col s3\"><a href=\"#test4\">Test 4</a></li>",
    "</Head>",
    "<Body>",
        "<div id=\"test1\" class=\"col s12\">Test 1</div>",
        "<div id=\"test2\" class=\"col s12\">Test 2</div>",
        "<div id=\"test3\" class=\"col s12\">Test 3</div>",
        "<div id=\"test4\" class=\"col s12\">Test 4</div>",
    "</Body>",
"</BM_tab>"
        };
    private string[] text2 = new string[]
    {
"<BM_tab Container=\"false\">",
    "<Head>",
        "<li class=\"tab col s3\"><a href=\"#test-swipe-1\">Test 1</a></li>",
        "<li class=\"tab col s3\"><a class=\"active\" href=\"#test-swipe-2\">Test 2</a></li>",
        "<li class=\"tab col s3\"><a href=\"#test-swipe-3\">Test 3</a></li>",
    "</Head>",
    "<Body>",
        "<div id=\"test-swipe-1\" class=\"col s12 blue\">Test 1</div>",
        "<div id=\"test-swipe-2\" class=\"col s12 red\">Test 2</div>",
        "<div id=\"test-swipe-3\" class=\"col s12 green\">Test 3</div>",
    "</Body>",
"</BM_tab>"
    };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
