#pragma checksum "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/BM_collection.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7377833c23ded6ff9e5942089376437f635d2d93"
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
    public partial class BM_collection : css_base
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 15 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/BM_collection.razor"
      
    [Parameter]
    public RenderFragment ChildContent{get;set;}
    [Parameter]
    public string Header{get;set;} = "";
    [Parameter]
    public int Font_Header{get;set;} = 4; //1-6
    
    private string valor = ""; 
    private bool ok_header = false;
    private string text_final = "";

    private string show="";

    protected override void OnInitialized(){
       
        if(!string.IsNullOrEmpty(Header)){
            valor += "with-header ";
            ok_header = true;
            switch (Font_Header)
            {
                case 1:
                text_final = "<h1>" + Header + "</h1>";
                break;
                 case 2:
                text_final = "<h2>" + Header + "</h2>";
                break;
                 case 3:
                text_final = "<h3>" + Header + "</h3>";
                break;
                 case 4:
                text_final = "<h4>" + Header + "</h4>";
                break;
                 case 5:
                text_final = "<h5>" + Header + "</h5>";
                break;
                 case 6:
                text_final = "<h6>" + Header + "</h6>";
                break;
                default:
                break;
            }
            
        }
       
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
