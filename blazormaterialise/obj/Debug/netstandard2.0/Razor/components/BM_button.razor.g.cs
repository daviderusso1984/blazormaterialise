#pragma checksum "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/BM_button.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfad437ec9ff00e1baf6ca538a224cb5f7c80c0b"
// <auto-generated/>
#pragma warning disable 1591
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
    public partial class BM_button : css_base
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "a");
            __builder.AddAttribute(1, "class", (
#line 6 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/BM_button.razor"
           valor

#line default
#line hidden
            ) + " " + (
#line 6 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/BM_button.razor"
                  Class

#line default
#line hidden
            ) + " " + (
#line 6 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/BM_button.razor"
                         _backcolor

#line default
#line hidden
            ) + " " + (
#line 6 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/BM_button.razor"
                                     _textcolor

#line default
#line hidden
            ) + " " + (
#line 6 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/BM_button.razor"
                                                 show

#line default
#line hidden
            ));
            __builder.AddMarkupContent(2, "\n    ");
            __builder.AddContent(3, 
#line 7 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/BM_button.razor"
     ChildContent

#line default
#line hidden
            );
            __builder.AddMarkupContent(4, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 10 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/BM_button.razor"
      

    [Parameter]
    public RenderFragment ChildContent{get;set;}
    [Parameter]
    public bool Waves_effect{get;set;} = true;
    [Parameter]
    public bool Disabled{get;set;} = false;
    [Parameter]
    public enum_button Type_button{get;set;}= enum_button.Flat;




    private string valor = "";

    private string show="";

    protected override void OnInitialized(){
        var sh = new show();
        show = sh.get_show(Visibility);
         if(Type_button == enum_button.Flat){
            if(Waves_effect){
            valor += "waves-effect waves-teal ";
        }
        }else{
            if(Waves_effect){
            valor += "waves-effect waves-light ";
        }
        }
        if(Disabled){
            valor += "disabled ";
        }
        
        var btn = new button();
        valor += btn.get_button(Type_button);
        
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591