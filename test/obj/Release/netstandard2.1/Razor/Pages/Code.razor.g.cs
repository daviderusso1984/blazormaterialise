#pragma checksum "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\test\Pages\Code.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a8524dc0cca60038ebc8bbde7d20b68fe0c5ecb"
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
    public partial class Code : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\n    .bg{\r\n        background-color: gray;\r\n        color: white;\r\n        width: 100%;\r\n        height:auto;\r\n        margin:10px;\r\n    }\n    code{\r\n        width:100%;\r\n        height:auto;\r\n    }\n</style>\n\n");
#nullable restore
#line 17 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\test\Pages\Code.razor"
 if(rows != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "bg");
            __builder.AddMarkupContent(4, "\n");
#nullable restore
#line 20 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\test\Pages\Code.razor"
        foreach(var item in rows)
       {

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "           ");
            __builder.OpenElement(6, "code");
            __builder.AddContent(7, 
#nullable restore
#line 22 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\test\Pages\Code.razor"
                  item

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "<br>\n");
#nullable restore
#line 23 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\test\Pages\Code.razor"
       }

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n");
#nullable restore
#line 25 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\test\Pages\Code.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\test\Pages\Code.razor"
      
    [Parameter]
    public string[] rows { get; set; }
    





#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
