#pragma checksum "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\forms\Select\BM_option.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5922de81a4324c04f1baef3c6831e1a419ecb7f"
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
#line 1 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 2 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 3 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
    public partial class BM_option<TValue> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 24 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\forms\Select\BM_option.razor"
      
    [CascadingParameter] 
    TValue Ing_value { get; set; }
    [Parameter]
    public enum_type_option Type{get;set;}=enum_type_option.String;   
    [Parameter]
    public TValue Value{get;set;}
    [Parameter]
    public string Text{get;set;} = "";
    [Parameter]
    public string Icon{get;set;} = "";

#line default
#line hidden
    }
}
#pragma warning restore 1591
