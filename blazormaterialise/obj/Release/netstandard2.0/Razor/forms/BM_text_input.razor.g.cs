#pragma checksum "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_text_input.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ea307438080c0477d373f382c34a87cf233e294"
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
    public partial class BM_text_input : forms_base
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "input-field col s12");
            __builder.AddMarkupContent(2, "\n");
#line 6 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_text_input.razor"
             if(!string.IsNullOrEmpty(Icon)){

#line default
#line hidden
            __builder.AddContent(3, "                ");
            __builder.OpenElement(4, "i");
            __builder.AddAttribute(5, "class", "material-icons prefix");
            __builder.AddContent(6, 
#line 7 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_text_input.razor"
                                                  Icon

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n");
#line 8 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_text_input.razor"
            }

#line default
#line hidden
#line 9 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_text_input.razor"
             if(Disabled){
                

#line default
#line hidden
#line 10 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_text_input.razor"
                 if(Active_text_limit){

#line default
#line hidden
            __builder.AddContent(8, "                    ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "disabled", true);
            __builder.AddAttribute(11, "value", 
#line 11 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_text_input.razor"
                                            Value

#line default
#line hidden
            );
            __builder.AddAttribute(12, "id", 
#line 11 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_text_input.razor"
                                                        Id

#line default
#line hidden
            );
            __builder.AddAttribute(13, "type", 
#line 11 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_text_input.razor"
                                                                   Type

#line default
#line hidden
            );
            __builder.AddAttribute(14, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#line 11 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_text_input.razor"
                                                                                   Change

#line default
#line hidden
            ));
            __builder.AddAttribute(15, "class", "validate ");
            __builder.AddAttribute(16, "data-length", 
#line 11 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_text_input.razor"
                                                                                                                           Text_limit

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n");
#line 12 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_text_input.razor"
                }else{

#line default
#line hidden
            __builder.AddContent(18, "                    ");
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "disabled", true);
            __builder.AddAttribute(21, "value", 
#line 13 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_text_input.razor"
                                            Value

#line default
#line hidden
            );
            __builder.AddAttribute(22, "id", 
#line 13 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_text_input.razor"
                                                        Id

#line default
#line hidden
            );
            __builder.AddAttribute(23, "type", 
#line 13 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_text_input.razor"
                                                                   Type

#line default
#line hidden
            );
            __builder.AddAttribute(24, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#line 13 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_text_input.razor"
                                                                                   Change

#line default
#line hidden
            ));
            __builder.AddAttribute(25, "class", "validate ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n");
#line 14 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_text_input.razor"
                }

#line default
#line hidden
#line 14 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_text_input.razor"
                                 
            }else{
                

#line default
#line hidden
#line 16 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_text_input.razor"
                 if(Active_text_limit){

#line default
#line hidden
            __builder.AddContent(27, "                    ");
            __builder.OpenElement(28, "input");
            __builder.AddAttribute(29, "value", 
#line 17 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_text_input.razor"
                                   Value

#line default
#line hidden
            );
            __builder.AddAttribute(30, "id", 
#line 17 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_text_input.razor"
                                               Id

#line default
#line hidden
            );
            __builder.AddAttribute(31, "type", 
#line 17 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_text_input.razor"
                                                          Type

#line default
#line hidden
            );
            __builder.AddAttribute(32, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#line 17 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_text_input.razor"
                                                                          Change

#line default
#line hidden
            ));
            __builder.AddAttribute(33, "class", "validate ");
            __builder.AddAttribute(34, "data-length", 
#line 17 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_text_input.razor"
                                                                                                                  Text_limit

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n");
#line 18 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_text_input.razor"
                }else{

#line default
#line hidden
            __builder.AddContent(36, "                    ");
            __builder.OpenElement(37, "input");
            __builder.AddAttribute(38, "value", 
#line 19 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_text_input.razor"
                                   Value

#line default
#line hidden
            );
            __builder.AddAttribute(39, "id", 
#line 19 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_text_input.razor"
                                               Id

#line default
#line hidden
            );
            __builder.AddAttribute(40, "type", 
#line 19 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_text_input.razor"
                                                          Type

#line default
#line hidden
            );
            __builder.AddAttribute(41, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#line 19 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_text_input.razor"
                                                                          Change

#line default
#line hidden
            ));
            __builder.AddAttribute(42, "class", "validate ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n");
#line 20 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_text_input.razor"
                }

#line default
#line hidden
#line 20 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_text_input.razor"
                                 
            }          

#line default
#line hidden
            __builder.AddContent(44, "          ");
            __builder.OpenElement(45, "label");
            __builder.AddAttribute(46, "for", 
#line 22 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_text_input.razor"
                       Id

#line default
#line hidden
            );
            __builder.AddContent(47, 
#line 22 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_text_input.razor"
                            Label

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\n          ");
            __builder.OpenElement(49, "span");
            __builder.AddAttribute(50, "class", "helper-text");
            __builder.AddAttribute(51, "data-error", "wrong");
            __builder.AddAttribute(52, "data-success", "right");
            __builder.AddContent(53, 
#line 23 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_text_input.razor"
                                                                             Helper_text

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\n        ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 30 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_text_input.razor"
      
    [Parameter]
    public string Value { get; set; } = "";
    [Parameter]
    public bool Active_text_limit{get;set;}= false;
    [Parameter]
    public int Text_limit{get;set;}=0;
    [Parameter]
    public string Icon { get; set; } = "";
    [Parameter]
    public string Type { get; set; } = "text";
    [Parameter]
    public bool Disabled { get; set; } = false;
    [Parameter]
    public string Label { get; set; } = "";
    [Parameter]
    public string Helper_text { get; set; } = "";
    [Parameter]
    public EventCallback<string> ValueChanged { get; set; }

    protected override void OnInitialized(){
        
    }    

     protected override async Task OnAfterRenderAsync (bool firstRender) {
        await base.OnAfterRenderAsync (firstRender);
        
        
    }   

    protected Task Change (ChangeEventArgs e) {
        Value = (string)e.Value;
        return  ValueChanged.InvokeAsync ((string) e.Value);
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591