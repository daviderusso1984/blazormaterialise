#pragma checksum "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Pages/Button.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39669b1680c73dd3cdf9446564b9091f027825ec"
// <auto-generated/>
#pragma warning disable 1591
namespace test.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/_Imports.razor"
using test;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/_Imports.razor"
using test.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/_Imports.razor"
using blazormaterialise;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Button")]
    public partial class Button : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Button</h3>\n\n");
            __Blazor.test.Pages.Button.TypeInference.CreateBM_table_0(__builder, 1, 2, 
#nullable restore
#line 7 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Pages/Button.razor"
                       Head_table

#line default
#line hidden
#nullable disable
            , 3, 
#nullable restore
#line 7 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Pages/Button.razor"
                                          list

#line default
#line hidden
#nullable disable
            , 4, (context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\n    ");
                __builder2.OpenElement(6, "td");
                __builder2.AddContent(7, 
#nullable restore
#line 8 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Pages/Button.razor"
         context.Propriety

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(8, "\n    ");
                __builder2.OpenElement(9, "td");
                __builder2.AddContent(10, 
#nullable restore
#line 9 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Pages/Button.razor"
         context.Value

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(11, "\n    ");
                __builder2.OpenElement(12, "td");
                __builder2.AddContent(13, 
#nullable restore
#line 10 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Pages/Button.razor"
         context.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\n");
            }
            );
            __builder.AddMarkupContent(15, "\n\n");
            __builder.AddMarkupContent(16, "<h5>Raised Button</h5>\n");
            __builder.OpenComponent<blazormaterialise.BM_button>(17);
            __builder.AddAttribute(18, "Type_button", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<blazormaterialise.enum_button>(
#nullable restore
#line 14 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Pages/Button.razor"
                        enum_button.Raised

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(20, "Reised");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(21, "\n");
            __builder.AddMarkupContent(22, "<p>Code</p>\n");
            __builder.OpenElement(23, "code");
            __builder.AddAttribute(24, "class", true);
            __builder.AddMarkupContent(25, "\n    ");
            __builder.AddContent(26, 
#nullable restore
#line 17 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Pages/Button.razor"
     Text_raised

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(27, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n");
            __builder.AddMarkupContent(29, "<h5>Raised Button</h5>\n");
            __builder.OpenComponent<blazormaterialise.BM_button>(30);
            __builder.AddAttribute(31, "Type_button", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<blazormaterialise.enum_button>(
#nullable restore
#line 20 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Pages/Button.razor"
                        enum_button.Flat

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(33, "Flat");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(34, "\n");
            __builder.AddMarkupContent(35, "<p>Code</p>\n");
            __builder.OpenElement(36, "code");
            __builder.AddAttribute(37, "class", true);
            __builder.AddMarkupContent(38, "\n    ");
            __builder.AddContent(39, 
#nullable restore
#line 23 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Pages/Button.razor"
     Text_flat

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(40, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\n");
            __builder.AddMarkupContent(42, "<h5>Raised Button</h5>\n");
            __builder.OpenComponent<blazormaterialise.BM_button>(43);
            __builder.AddAttribute(44, "Type_button", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<blazormaterialise.enum_button>(
#nullable restore
#line 26 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Pages/Button.razor"
                        enum_button.Large

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(46, "Large");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(47, "\n");
            __builder.AddMarkupContent(48, "<p>Code</p>\n");
            __builder.OpenElement(49, "code");
            __builder.AddAttribute(50, "class", true);
            __builder.AddMarkupContent(51, "\n    ");
            __builder.AddContent(52, 
#nullable restore
#line 29 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Pages/Button.razor"
     Text_large

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(53, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\n");
            __builder.AddMarkupContent(55, "<h5>Raised Button</h5>\n");
            __builder.OpenComponent<blazormaterialise.BM_button>(56);
            __builder.AddAttribute(57, "Type_button", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<blazormaterialise.enum_button>(
#nullable restore
#line 32 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Pages/Button.razor"
                        enum_button.Small

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(59, "Small");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(60, "\n");
            __builder.AddMarkupContent(61, "<p>Code</p>\n");
            __builder.OpenElement(62, "code");
            __builder.AddAttribute(63, "class", true);
            __builder.AddMarkupContent(64, "\n    ");
            __builder.AddContent(65, 
#nullable restore
#line 35 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Pages/Button.razor"
     Text_small

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(66, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\n");
            __builder.AddMarkupContent(68, "<h5>Raised Button</h5>\n");
            __builder.OpenComponent<blazormaterialise.BM_button>(69);
            __builder.AddAttribute(70, "Type_button", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<blazormaterialise.enum_button>(
#nullable restore
#line 38 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Pages/Button.razor"
                        enum_button.Floating

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(71, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<blazormaterialise.BM_icon>(72);
                __builder2.AddAttribute(73, "icon", "add");
                __builder2.CloseComponent();
                __builder2.AddContent(74, ">");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(75, "\n");
            __builder.AddMarkupContent(76, "<p>Code</p>\n");
            __builder.OpenElement(77, "code");
            __builder.AddAttribute(78, "class", true);
            __builder.AddMarkupContent(79, "\n    ");
            __builder.AddContent(80, 
#nullable restore
#line 41 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Pages/Button.razor"
     Text_floating

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(81, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Pages/Button.razor"
      
    private string[] Head_table = new string[]{"Propriety" , "Value" , "Description"};
    private struct_table[] list = new struct_table[10];

    private string Text_raised = "<BM_button Type_button=\"enum_button.Raised\">Reised</BM_button>";
    private string Text_floating ="<BM_button Type_button=\"enum_button.Floating\">Floating</BM_button>";
    private string Text_small = "<BM_button Type_button=\"enum_button.Small\">Small</BM_button>";
    private string Text_flat ="<BM_button Type_button=\"enum_button.Flat\">Flat</BM_button>";
    private string Text_large = "<BM_button Type_button=\"enum_button.Large\">Large</BM_button>";



   protected override void OnInitialized(){
       list[0] = new struct_table{Propriety="Waves_effect", Value="bool" , Description="Active effect Waves"};
       list[1] = new struct_table{Propriety="Disabled", Value="bool" , Description="Disabled control"};
       list[2] = new struct_table{Propriety="Type_button", Value="enum_button" , Description="Select type button: Raised , Floating, Flat , Large , Small"};
       list[3] = new struct_table{Propriety="Onclick", Value="MouseEventArgs" , Description="Event click button"};
       list[4] = new struct_table{Propriety="Class", Value="string" , Description="Include class name"};
       list[5] = new struct_table{Propriety="Backcolor", Value="string" , Description="go to color"};
       list[6] = new struct_table{Propriety="Textcolor", Value="string" , Description="go to color"};
       list[7] = new struct_table{Propriety="Visibility", Value="enum_show" , Description="show or hide control "};
       list[8] = new struct_table{Propriety="Id", Value="string" , Description="Id generate auto"};
       list[9] = new struct_table{Propriety="Ref", Value="strig" , Description="reference control "};

   }




   

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.test.Pages.Button
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateBM_table_0<TableItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String[] __arg0, int __seq1, global::System.Collections.Generic.IEnumerable<TableItem> __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment<TableItem> __arg2)
        {
        __builder.OpenComponent<global::blazormaterialise.BM_table<TableItem>>(seq);
        __builder.AddAttribute(__seq0, "Head_items", __arg0);
        __builder.AddAttribute(__seq1, "Items", __arg1);
        __builder.AddAttribute(__seq2, "ChildContent", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
