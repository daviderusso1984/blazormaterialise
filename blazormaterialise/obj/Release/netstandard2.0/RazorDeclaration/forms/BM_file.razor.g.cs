#pragma checksum "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_file.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e1d1c4f425358feed96730d98834892028fb55d"
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
    public partial class BM_file : forms_base
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 18 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_file.razor"
      
    [Parameter]
    public string Text { get; set; } = "";
    [Parameter]
    public string Placeholder { get; set; } = "";
    [Parameter]
    public EventCallback<System.IO.MemoryStream> Files{get;set;}

    async Task HandleSelection (IFileListEntry[] files) {
        var file = files.FirstOrDefault ();
        if (file != null) {
            // Just load into .NET memory to show it can be done
            // Alternatively it could be saved to disk, or parsed in memory, or similar
            var ms = new System.IO.MemoryStream ();
            await file.Data.CopyToAsync (ms);
            await Files.InvokeAsync(ms);
            //status = $"Finished loading {file.Size} bytes from {file.Name}";
        }
    }

    

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
