#pragma checksum "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\forms\Picker\BM_time_picker.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0082f97559eecd6d98068addc00400db8965e620"
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
    public partial class BM_time_picker : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "input");
            __builder.AddAttribute(1, "type", "text");
            __builder.AddAttribute(2, "class", "timepicker");
            __builder.AddAttribute(3, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#line 6 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\forms\Picker\BM_time_picker.razor"
                                                   (ChangeEventArgs __e) => onch(__e.Value.ToString())

#line default
#line hidden
            ));
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 10 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\forms\Picker\BM_time_picker.razor"
      

    [Parameter]
    public EventCallback<string> Value{get;set;}

     protected override async Task OnAfterRenderAsync (bool firstRender) {
        await base.OnAfterRenderAsync (firstRender);
        
        await JSRuntime.InvokeVoidAsync("timepicker_init");
        
    }   
     private void onch(string value){
        Value.InvokeAsync(value);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
