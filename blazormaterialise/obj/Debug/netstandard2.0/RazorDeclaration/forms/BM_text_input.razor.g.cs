#pragma checksum "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_text_input.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e96a8a4e9b63cc619c409add0e86d2df4eeea5b9"
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
    public partial class BM_text_input : forms_base
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 30 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_text_input.razor"
      
    [Parameter]
    public string Value { get; set; } = "";
    [Parameter]
    public bool Active_text_limit{get;set;}= false;
    [Parameter]
    public int Text_limit{get;set;}=0;
    [Parameter]
    public string Icon { get; set; } = "";
    [Parameter]
    public string Type { get; set; } = "text";
    [Parameter]
    public bool Disabled { get; set; } = false;
    [Parameter]
    public string Label { get; set; } = "";
    [Parameter]
    public string Helper_text { get; set; } = "";
    [Parameter]
    public EventCallback<string> ValueChanged { get; set; }

    protected override void OnInitialized(){
        
    }    

     protected override async Task OnAfterRenderAsync (bool firstRender) {
        await base.OnAfterRenderAsync (firstRender);
        
        
    }   

    protected Task Change (ChangeEventArgs e) {
        Value = (string)e.Value;
        return  ValueChanged.InvokeAsync ((string) e.Value);
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
