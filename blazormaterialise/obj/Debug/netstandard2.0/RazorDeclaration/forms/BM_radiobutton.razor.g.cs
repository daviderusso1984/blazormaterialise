#pragma checksum "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_radiobutton.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd4840b528907910f502181b7cfe92c6f6587dab"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class BM_radiobutton : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 27 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_radiobutton.razor"
      

    [Parameter]
    public string Text { get; set; } = "";
    [Parameter]
    public bool Checked { get; set; } = false;
    [Parameter]
    public bool Disabled { get; set; } = false;
    [Parameter]
    public EventCallback<bool> Onchange { get; set; }

    protected void Change (ChangeEventArgs e) {
        Onchange.InvokeAsync ((bool) e.Value);
    }

    

#line default
#line hidden
    }
}
#pragma warning restore 1591