#pragma checksum "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_radiobutton.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a47075a17db6d71d01d0b6b05f99980bcbb3287a"
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
    public partial class BM_radiobutton<TValue> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "label");
            __builder.AddMarkupContent(1, "\r\n");
#line 7 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_radiobutton.razor"
     if (Checked)
    {
        

#line default
#line hidden
#line 9 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_radiobutton.razor"
         if (Disabled)
        {

#line default
#line hidden
            __builder.AddContent(2, "            ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "class", 
#line 11 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_radiobutton.razor"
                           dim

#line default
#line hidden
            );
            __builder.AddAttribute(5, "name", "group1");
            __builder.AddAttribute(6, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#line 11 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_radiobutton.razor"
                                                         ((e) => OnChangeHandler(e))

#line default
#line hidden
            ));
            __builder.AddAttribute(7, "type", "radio");
            __builder.AddAttribute(8, "checked", true);
            __builder.AddAttribute(9, "disabled", true);
            __builder.AddAttribute(10, "value", 
#line 11 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_radiobutton.razor"
                                                                                                                             Convert.ToString(Value)

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
#line 12 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_radiobutton.razor"
        }
        else
        {

#line default
#line hidden
            __builder.AddContent(12, "            ");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "class", 
#line 15 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_radiobutton.razor"
                           dim

#line default
#line hidden
            );
            __builder.AddAttribute(15, "name", "group1");
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#line 15 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_radiobutton.razor"
                                                         ((e) => OnChangeHandler(e))

#line default
#line hidden
            ));
            __builder.AddAttribute(17, "type", "radio");
            __builder.AddAttribute(18, "checked", true);
            __builder.AddAttribute(19, "value", 
#line 15 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_radiobutton.razor"
                                                                                                                    Convert.ToString(Value)

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
#line 16 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_radiobutton.razor"
        }

#line default
#line hidden
#line 16 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_radiobutton.razor"
         

    }
    else
    {
        

#line default
#line hidden
#line 21 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_radiobutton.razor"
         if (Disabled)
        {

#line default
#line hidden
            __builder.AddContent(21, "            ");
            __builder.OpenElement(22, "input");
            __builder.AddAttribute(23, "class", 
#line 23 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_radiobutton.razor"
                           dim

#line default
#line hidden
            );
            __builder.AddAttribute(24, "name", "group1");
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#line 23 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_radiobutton.razor"
                                                         ((e) => OnChangeHandler(e))

#line default
#line hidden
            ));
            __builder.AddAttribute(26, "type", "radio");
            __builder.AddAttribute(27, "disabled", true);
            __builder.AddAttribute(28, "value", 
#line 23 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_radiobutton.razor"
                                                                                                                     Convert.ToString(Value)

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
#line 24 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_radiobutton.razor"
        }
        else
        {

#line default
#line hidden
            __builder.AddContent(30, "            ");
            __builder.OpenElement(31, "input");
            __builder.AddAttribute(32, "class", 
#line 27 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_radiobutton.razor"
                           dim

#line default
#line hidden
            );
            __builder.AddAttribute(33, "name", "group1");
            __builder.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#line 27 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_radiobutton.razor"
                                                         ((e) => OnChangeHandler(e))

#line default
#line hidden
            ));
            __builder.AddAttribute(35, "type", "radio");
            __builder.AddAttribute(36, "value", 
#line 27 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_radiobutton.razor"
                                                                                                            Convert.ToString(Value)

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n");
#line 28 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_radiobutton.razor"
        }

#line default
#line hidden
#line 28 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_radiobutton.razor"
         

    }

#line default
#line hidden
            __builder.AddMarkupContent(38, "\r\n    ");
            __builder.OpenElement(39, "span");
            __builder.AddContent(40, 
#line 32 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_radiobutton.razor"
           Text

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 36 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/blazormaterialise/forms/BM_radiobutton.razor"
      
    [Parameter]
    public TValue Value { get; set; }

    [Parameter]
    public string Text { get; set; } = "";
    [Parameter]
    public bool Checked { get; set; } = false;
    [Parameter]
    public bool Disabled { get; set; } = false;
    [Parameter]
    public bool With_gap{get;set;}=false;
    [Parameter]
    public EventCallback<string> Onchecked { get; set; }

    private string dim = "";    

    protected override void OnInitialized()
    {
        if (Checked)
        {
            Onchecked.InvokeAsync(Value.ToString());
        }
        dim = "";
        if(With_gap){
            dim += "with-gap ";
        }
    }


    private void OnChangeHandler(ChangeEventArgs e)
    {        
        Onchecked.InvokeAsync(e.Value.ToString());
    }



#line default
#line hidden
    }
}
#pragma warning restore 1591
