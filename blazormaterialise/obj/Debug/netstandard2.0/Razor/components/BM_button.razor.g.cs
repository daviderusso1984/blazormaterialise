#pragma checksum "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/Components/BM_button.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "043975c7046c6823f585f254b77d494c21935cfe"
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
#line 3 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
    public partial class BM_button : css_base
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "a");
            __builder.AddAttribute(1, "class", (
#line 6 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/Components/BM_button.razor"
           valor

#line default
#line hidden
            ) + " " + (
#line 6 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/Components/BM_button.razor"
                  dim

#line default
#line hidden
            ) + " " + (
#line 6 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/Components/BM_button.razor"
                       Class

#line default
#line hidden
            ));
            __builder.AddAttribute(2, "id", 
#line 6 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/Components/BM_button.razor"
                                   Id

#line default
#line hidden
            );
            __builder.AddAttribute(3, "ref", 
#line 6 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/Components/BM_button.razor"
                                             Ref

#line default
#line hidden
            );
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 6 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/Components/BM_button.razor"
                                                            click

#line default
#line hidden
            ));
            __builder.AddMarkupContent(5, "\n    ");
            __builder.AddContent(6, 
#line 7 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/Components/BM_button.razor"
     ChildContent

#line default
#line hidden
            );
            __builder.AddMarkupContent(7, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 10 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/Components/BM_button.razor"
      

    [Parameter]
    public RenderFragment ChildContent{get;set;}
    [Parameter]
    public bool Waves_effect{get;set;} = true;
    [Parameter]
    public bool Disabled{get;set;} = false;
    [Parameter]
    public enum_button Type_button{get;set;}= enum_button.Flat;
    [Parameter]
    public EventCallback<MouseEventArgs> Onclick{get;set;}


    protected async void click(MouseEventArgs ev){
        await Onclick.InvokeAsync(ev);
    }

    private string valor = "";



    private string dim = "";

    protected override void OnInitialized(){

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
        dim += blazormaterialise.show.get_show(Visibility) + " ";
        dim += color.get_backcolor(color.get_color(Backcolor)) + " ";
        dim += color.get_Textcolor(color.get_color(Textcolor)) + " ";

    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
