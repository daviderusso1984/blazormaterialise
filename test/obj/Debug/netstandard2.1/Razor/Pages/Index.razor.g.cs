#pragma checksum "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d0905b2fd62ac6d506d3e64d432b15051e8c587"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<blazormaterialise.BM_file>(0);
            __builder.AddAttribute(1, "Text", "Ciao");
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n");
            __builder.OpenComponent<blazormaterialise.BM_textarea>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenComponent<blazormaterialise.BM_select>(5);
            __builder.AddAttribute(6, "Items", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<blazormaterialise.structure_select[]>(
#nullable restore
#line 5 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Pages/Index.razor"
                  sel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "Label", "Mondo Cane");
            __builder.AddAttribute(8, "Value", "ciao2");
            __builder.AddAttribute(9, "Onchange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 5 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Pages/Index.razor"
                                                                  mii

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, " \r\n");
            __builder.OpenElement(11, "p");
            __builder.AddContent(12, 
#nullable restore
#line 6 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Pages/Index.razor"
    date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorMaterialize/test/Pages/Index.razor"
      

    private blazormaterialise.structure_select[] sel = new blazormaterialise.structure_select[]{
        new structure_select {Value="ciao", Text="Ciao"},
        new structure_select {Value="ciao1", Text="Ciao1"},
        new structure_select {Value="ciao2", Text="Ciao2"}
    };

    string date = "";
    private void mii(string cc){
        date = cc;
    }

    private void che(bool ok){
        Console.WriteLine(ok);
    }

    private void click(){
        var t = new blazormaterialise.BM_toast(JSRuntime,"<span>I am toast content</span><button class=\"btn-flat toast-action\">Undo</button>" ,"fi", false);
        t.show();    
    }

    private void cc(int x){
        Console.WriteLine(x);
        
    }
    
    public string[] he = new string[]{"ciao","mio","dio"};
    public IEnumerable<Car> cars;

        private string mio = "mio" + Guid.NewGuid();
        private string mio1 = "mio1" + Guid.NewGuid();

   protected override async Task OnInitializedAsync()
    {
         cars = new[]
            {
                new Car("Volkswagen Golf", 10000, 220),
                new Car("Volkswagen Passat", 11000, 240),
                new Car("Volkswagen Polo", 12000, 110),
                new Car("Ford Focus", 13000, 200),
                new Car("Ford Fiesta", 14000, 160),
                new Car("Ford Fusion", 15000, 260),
                new Car("Ford Mondeo", 16000, 120),
            };
    }
    protected override void OnAfterRender(bool firstRender){
        
    }

    public class Car
            {
                public string Name { get; set; }
                public double Price { get; set; }
                public int Horsepower { get; set; }
 
                public Car(string name, double price, int horsepower)
                {
                    Name = name;
                    Price = price;
                    Horsepower = horsepower;
                }
            }

     

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
