#pragma checksum "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/Components/Dropdown/BM_dropdown_item.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e86591542c632fe14070e80c77a8dc93d79c1cc6"
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
    public partial class BM_dropdown_item : js_base
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 4 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/Components/Dropdown/BM_dropdown_item.razor"
 if (Type == enum_type_dropdown_item.link)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "li");
            __builder.OpenElement(2, "a");
            __builder.AddAttribute(3, "id", 
#line 6 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/Components/Dropdown/BM_dropdown_item.razor"
                Id

#line default
#line hidden
            );
            __builder.AddAttribute(4, "class", (
#line 6 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/Components/Dropdown/BM_dropdown_item.razor"
                            dim

#line default
#line hidden
            ) + " " + (
#line 6 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/Components/Dropdown/BM_dropdown_item.razor"
                                 Class

#line default
#line hidden
            ) + " ");
            __builder.AddAttribute(5, "href", 
#line 6 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/Components/Dropdown/BM_dropdown_item.razor"
                                                Href

#line default
#line hidden
            );
            __builder.AddContent(6, 
#line 6 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/Components/Dropdown/BM_dropdown_item.razor"
                                                        ChildContent

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
#line 7 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/Components/Dropdown/BM_dropdown_item.razor"
}

#line default
#line hidden
#line 8 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/Components/Dropdown/BM_dropdown_item.razor"
 if (Type == enum_type_dropdown_item.divider)
{

#line default
#line hidden
            __builder.AddMarkupContent(8, "    <li class=\"divider\" tabindex=\"-1\"></li>\r\n");
#line 11 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/Components/Dropdown/BM_dropdown_item.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 17 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/Components/Dropdown/BM_dropdown_item.razor"
      
    [Parameter]
    public RenderFragment ChildContent { get; set; }


    [Parameter]
    public string Href { get; set; } = "";

    [Parameter]
    public enum_type_dropdown_item Type { get; set; } = enum_type_dropdown_item.link;



    private string dim = "";
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
