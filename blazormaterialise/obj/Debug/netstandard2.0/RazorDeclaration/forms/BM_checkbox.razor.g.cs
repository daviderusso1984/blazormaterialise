#pragma checksum "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\forms\BM_checkbox.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62a9b98c1bc7efaf6976508ddfbb634a4a8373a7"
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
    public partial class BM_checkbox : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 32 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\blazormaterialise\forms\BM_checkbox.razor"
          

        [Parameter]
        public string Title{get;set;} = "";

        [Parameter]
        public EventCallback<bool> Onchange{get;set;}
        [Parameter]
        public bool Value{get;set;} = false;
        [Parameter]
        public bool Filled_in{get;set;} = false;
       
        [Parameter]
        public bool Disable{get;set;}= false;
        [Parameter]
        public EventCallback<bool> ValueChanged { get; set; }


        protected Task Change(ChangeEventArgs e)
        {
            Value = (bool)e.Value;
            return ValueChanged.InvokeAsync((bool)e.Value);
        }



        private string _class = "";





        protected override async Task OnAfterRenderAsync(bool firstRender){
            await base.OnAfterRenderAsync(firstRender);
            if(Filled_in && _class==""){
                _class = "filled-in ";
                this.StateHasChanged();
            }


        }


    

#line default
#line hidden
    }
}
#pragma warning restore 1591
