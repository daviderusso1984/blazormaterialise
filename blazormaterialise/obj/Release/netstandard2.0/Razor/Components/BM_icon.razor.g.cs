#pragma checksum "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\Components\BM_icon.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd9526a97dfb93d60c86f4567cd82b6544b3553a"
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
    public partial class BM_icon : css_base
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "i");
            __builder.AddAttribute(1, "class", (
#line 4 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\Components\BM_icon.razor"
            icon.get_icon_size(Size)

#line default
#line hidden
            ) + " material-icons" + " " + (
#line 4 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\Components\BM_icon.razor"
                                                     dim

#line default
#line hidden
            ));
            __builder.AddAttribute(2, "id", 
#line 4 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\Components\BM_icon.razor"
                                                               Id

#line default
#line hidden
            );
            __builder.AddContent(3, 
#line 4 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\Components\BM_icon.razor"
                                                                     Icon

#line default
#line hidden
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 7 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\Components\BM_icon.razor"
       
     [Parameter]
     public string Icon { get; set; } = "";
     [Parameter]
     public enum_icon_size Size { get; set; } = enum_icon_size.medium;

     
    private string dim ="";
     protected override void OnInitialized()
     {
          dim = "";
        dim += blazormaterialise.show.get_show(Visibility) + " ";
        dim += color.get_backcolor(color.get_color(Backcolor)) + " ";
        dim += color.get_Textcolor(color.get_color(Textcolor)) + " ";
     }

#line default
#line hidden
    }
}
#pragma warning restore 1591
