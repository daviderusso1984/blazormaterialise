#pragma checksum "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\Components\BM_breadcrumb.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5f5e5d6fe78e5ea6daa508877d702674740a4ba"
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
    public partial class BM_breadcrumb : css_base
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", (
#line 7 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\Components\BM_breadcrumb.razor"
               Class

#line default
#line hidden
            ) + " " + (
#line 7 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\Components\BM_breadcrumb.razor"
                      dim

#line default
#line hidden
            ));
            __builder.AddAttribute(2, "id", 
#line 7 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\Components\BM_breadcrumb.razor"
                                Id

#line default
#line hidden
            );
            __builder.AddAttribute(3, "r", true);
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "nav-wrapper");
            __builder.AddMarkupContent(7, "\r\n      ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col s12");
            __builder.AddMarkupContent(10, "\r\n");
#line 10 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\Components\BM_breadcrumb.razor"
           if(Items != null){
              

#line default
#line hidden
#line 11 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\Components\BM_breadcrumb.razor"
               foreach (var item in Items)
              {

#line default
#line hidden
            __builder.AddContent(11, "                  ");
            __builder.OpenElement(12, "a");
            __builder.AddAttribute(13, "href", 
#line 13 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\Components\BM_breadcrumb.razor"
                            item.href

#line default
#line hidden
            );
            __builder.AddAttribute(14, "class", "breadcrumb" + " " + (
#line 13 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\Components\BM_breadcrumb.razor"
                                                          item.Class

#line default
#line hidden
            ));
            __builder.AddContent(15, 
#line 13 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\Components\BM_breadcrumb.razor"
                                                                       item.name

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
#line 14 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\Components\BM_breadcrumb.razor"
              }

#line default
#line hidden
#line 14 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\Components\BM_breadcrumb.razor"
               
          }      

#line default
#line hidden
            __builder.AddContent(17, "      ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n  ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 20 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\Components\BM_breadcrumb.razor"
      

    [Parameter]
    public structure_breadcrumbs[] Items {get;set;}

    private string dim="";

    protected override void OnInitialized(){
      dim = "";
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
