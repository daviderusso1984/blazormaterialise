#pragma checksum "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/BM_pagination.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f935022df22eb2b28c44e18743425cba021d181"
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
    public partial class BM_pagination : css_base
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 28 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/components/BM_pagination.razor"
        
      [Parameter]
      public int Items{get;set;} = 0;

      [Parameter]
      public int Items_active {get;set;} = 0;

      [Parameter] 
      public EventCallback<int> Items_click { get; set; }

      private void click(int x){
          Items_click.InvokeAsync(x);
      }    

      private void left_click(int x){          
          if(x == 1){
            return;
          }
          Items_click.InvokeAsync(x - 1);          
      }

      private void right_click(int x){
          if(x == Items){
              return;
          }
          Items_click.InvokeAsync(x + 1);
      }





  

#line default
#line hidden
    }
}
#pragma warning restore 1591
