#pragma checksum "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\test\Pages\Breadcrumbs.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "614154d6cdfaf5247d24d99ede63959dc63bb400"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Breadcrumbs")]
    public partial class Breadcrumbs : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Breadcrumbs</h3>\r\n\r\n");
            __builder.OpenComponent<blazormaterialise.BM_breadcrumb>(1);
            __builder.AddAttribute(2, "Items", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<blazormaterialise.structure_breadcrumbs[]>(
#nullable restore
#line 5 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\test\Pages\Breadcrumbs.razor"
                      item

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\test\Pages\Breadcrumbs.razor"
       


    private structure_breadcrumbs[] item = new structure_breadcrumbs[]
    {
        new structure_breadcrumbs{ Class="" , href="" , name="One" },
        new structure_breadcrumbs{ Class="" , href="" , name="Two" },
        new structure_breadcrumbs{ Class="" , href="" , name="Three" }
    };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
