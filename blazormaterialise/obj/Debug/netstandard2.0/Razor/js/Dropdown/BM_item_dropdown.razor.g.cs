#pragma checksum "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/js/Dropdown/BM_item_dropdown.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ce146fd0de65b9f3f05626665606c7d08cfec36"
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
    public partial class BM_item_dropdown : js_base
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "li");
            __builder.OpenElement(1, "a");
            __builder.AddAttribute(2, "id", 
#line 5 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/js/Dropdown/BM_item_dropdown.razor"
            Id

#line default
#line hidden
            );
            __builder.AddAttribute(3, "class", (
#line 5 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/js/Dropdown/BM_item_dropdown.razor"
                        Class

#line default
#line hidden
            ) + " " + (
#line 5 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/js/Dropdown/BM_item_dropdown.razor"
                               show

#line default
#line hidden
            ));
            __builder.AddAttribute(4, "href", 
#line 5 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/js/Dropdown/BM_item_dropdown.razor"
                                            Href

#line default
#line hidden
            );
            __builder.AddContent(5, 
#line 5 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/js/Dropdown/BM_item_dropdown.razor"
                                                   ChildContent

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 8 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/js/Dropdown/BM_item_dropdown.razor"
      
    [Parameter]
    public RenderFragment ChildContent { get; set; }


    [Parameter]
    public string Href{get;set;} = "";
   


     private string show="";
     protected override async Task OnAfterRenderAsync(bool firstRender){
        await base.OnAfterRenderAsync(firstRender);
        
       
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
