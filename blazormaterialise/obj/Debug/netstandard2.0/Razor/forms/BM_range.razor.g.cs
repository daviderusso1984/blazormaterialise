#pragma checksum "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\forms\BM_range.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "052f9e5dabe14b060c40ee9c913d252977498c83"
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
    public partial class BM_range : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "p");
            __builder.AddAttribute(1, "class", "range-field");
            __builder.AddMarkupContent(2, "\r\n");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "range");
            __builder.AddAttribute(5, "id", "test5");
            __builder.AddAttribute(6, "step", 
#line 5 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\forms\BM_range.razor"
                                      Step

#line default
#line hidden
            );
            __builder.AddAttribute(7, "min", 
#line 5 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\forms\BM_range.razor"
                                                  Min

#line default
#line hidden
            );
            __builder.AddAttribute(8, "max", 
#line 5 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\forms\BM_range.razor"
                                                             Max

#line default
#line hidden
            );
            __builder.AddAttribute(9, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#line 5 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\forms\BM_range.razor"
                                                                            Change

#line default
#line hidden
            ));
            __builder.AddAttribute(10, "value", 
#line 5 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\forms\BM_range.razor"
                                                                                            Value

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 8 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\forms\BM_range.razor"
      
    [Parameter]
    public float Min {get;set;}= 0;
    [Parameter]
    public float Max{get;set;}=0;
    [Parameter]
    public float Step{get;set;}=0;
    [Parameter]
    public float Value{get;set;}=0;
    [Parameter]
    public EventCallback<float> ValueChanged { get; set; }

         protected Task Change(ChangeEventArgs e)
        {
            Value = Convert.ToSingle(e.Value);
            return ValueChanged.InvokeAsync(Convert.ToSingle(e.Value));
        }

     protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await base.OnAfterRenderAsync(firstRender);
        if (firstRender)
        {
            await JSRuntime.InvokeVoidAsync("range_init");
        }


    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
