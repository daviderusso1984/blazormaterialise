#pragma checksum "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/Components/Collapsible/BM_collapsible_item.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e23b29da0b6f26f1dfa6aeaf6a7659de7738fb40"
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
    public partial class BM_collapsible_item : js_base
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 16 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/Components/Collapsible/BM_collapsible_item.razor"
      
    [Parameter]
    public RenderFragment Header{get;set;}
    [Parameter]
    public RenderFragment Body{get;set;}   
   
    [Parameter]
    public Boolean Active{get;set;}= false;

    private string dim="";
    private string _active = "";

    private string get_active(bool ok)
    {
        if (ok)
        {
            
            return "active";
        }
        else
        {
            
            return "a";
        }
    }

    protected override void OnParametersSet(){
        _active = "";
        if(Active){
            _active ="active";
        }else{
            this.InvokeStateHasChanged();
        }       
        dim = "";
        if(Visibility != enum_show.show){
            dim += blazormaterialise.show.get_show(Visibility) + " ";
        }
        if(Backcolor != enum_color.not){
            dim += color.get_backcolor(color.get_color(Backcolor)) + " ";
        }
        if(Textcolor != enum_color.not){
            dim += color.get_Textcolor(color.get_color(Textcolor)) + " ";
        }       
        //StateHasChanged();
    }

    protected override void OnInitialized(){

        
    }





#line default
#line hidden
    }
}
#pragma warning restore 1591
