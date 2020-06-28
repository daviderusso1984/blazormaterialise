#pragma checksum "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/Table/BM_table.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7206c2443ac1bfd08144acb34022b984812ea2a6"
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
    public partial class BM_table<TableItem> : css_base
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddMarkupContent(1, "\n        ");
            __builder.OpenElement(2, "thead");
            __builder.AddMarkupContent(3, "\n          ");
            __builder.OpenElement(4, "tr");
            __builder.AddMarkupContent(5, "\n");
#line 10 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/Table/BM_table.razor"
               if(@Head_items != null){
                  

#line default
#line hidden
#line 11 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/Table/BM_table.razor"
                   foreach (var item in Head_items)
                  {

#line default
#line hidden
            __builder.AddContent(6, "                      ");
            __builder.OpenElement(7, "th");
            __builder.AddContent(8, 
#line 13 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/Table/BM_table.razor"
                           item

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n");
#line 14 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/Table/BM_table.razor"
                  }

#line default
#line hidden
#line 14 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/Table/BM_table.razor"
                   
              }                            

#line default
#line hidden
            __builder.AddContent(10, "          ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n        ");
            __builder.OpenElement(13, "tbody");
            __builder.AddMarkupContent(14, "\n");
#line 19 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/Table/BM_table.razor"
             if (ItemList != null)
            {
                

#line default
#line hidden
#line 21 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/Table/BM_table.razor"
                 foreach (var item in ItemList)
                {

#line default
#line hidden
            __builder.AddContent(15, "                    ");
            __builder.OpenElement(16, "tr");
            __builder.AddContent(17, 
#line 23 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/Table/BM_table.razor"
                         ChildContent(item)

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "                    \n");
#line 24 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/Table/BM_table.razor"
                }

#line default
#line hidden
#line 24 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/Table/BM_table.razor"
                 
            }          

#line default
#line hidden
            __builder.AddContent(19, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n");
#line 27 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/Table/BM_table.razor"
         if(Pagination_show){

#line default
#line hidden
            __builder.AddContent(21, "            ");
            __builder.OpenElement(22, "tfoot");
            __builder.AddAttribute(23, "class", true);
            __builder.AddMarkupContent(24, "\n                ");
            __builder.OpenComponent<blazormaterialise.BM_pagination>(25);
            __builder.AddAttribute(26, "Items", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#line 29 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/Table/BM_table.razor"
                                      total_page

#line default
#line hidden
            ));
            __builder.AddAttribute(27, "Items_active", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#line 29 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/Table/BM_table.razor"
                                                                currentPage

#line default
#line hidden
            ));
            __builder.AddAttribute(28, "Items_click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#line 29 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/Table/BM_table.razor"
                                                                                          pag_eve

#line default
#line hidden
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(29, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n");
#line 31 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/Table/BM_table.razor"
        }

#line default
#line hidden
            __builder.AddContent(31, "      ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 37 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/Table/BM_table.razor"
      

    [Parameter]
    public string[] Head_items {get;set;}   
    
    [Parameter]
    public IEnumerable<TableItem> Items { get; set; }

    
    public IEnumerable<TableItem> ItemList { get; set; }


    [Parameter]
    public RenderFragment<TableItem> ChildContent { get; set; }
    [Parameter]
    public bool Pagination_show{get;set;} = false; 
    [Parameter]
    public int Pagination_divider {get;set;} = 1;

    public int total_page = 0;

    public int currentPage = 0;

    protected override void OnInitialized(){
        
        if(Pagination_show){
            total_page  = Items.Count() / Pagination_divider;
            var div = Items.Count() % Pagination_divider;
            if(div != 0){
                total_page += 1;
            }
            pag_eve(1);
        }else{
            ItemList = Items;
            //await JSRuntime.InvokeAsync<string>("console.log", Items);
           
            this.StateHasChanged();
        }
    }




    private void pag_eve(int item){
        
        currentPage = item;
        ItemList = Items.Skip((currentPage - 1) * Pagination_divider).Take(Pagination_divider);
        this.StateHasChanged();
    }




#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591