#pragma checksum "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\test\Pages\Prova.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50ee87ec487646360acf8fe175b9e5ed7a3e8e06"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace test.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\test\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\test\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\test\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\test\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\test\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\test\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\test\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\test\_Imports.razor"
using test;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\test\_Imports.razor"
using test.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\test\_Imports.razor"
using blazormaterialise;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/prova")]
    public partial class Prova : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\david\Source\Repos\daviderusso1984\blazormaterialise\test\Pages\Prova.razor"
      

    public static readonly int[] LISTA_ANNI_SUPERENALOTTO = new int[] { 2020, 2019, 2018, 2017, 2016, 2015, 2014, 2013, 2012, 2011, 2010, 2009 };


    string anno = LISTA_ANNI_SUPERENALOTTO[0].ToString();

    private async Task carica()
    {
        await Caricamento();
    }

    public struttura_archivio_superenalotto[] archivio = new struttura_archivio_superenalotto[0];

    protected override async Task OnInitializedAsync()
    {
        await Caricamento();

    }

    private async Task Caricamento()
    {

        //archivio = new espiko.Models.struttura_archivio_superenalotto[0];
        archivio = await Leggi_archivio_superenalotto(anno);
        //StateHasChanged();
        Console.WriteLine(archivio.Length);
    }
    public static readonly string PATH_BASE = "https://localhost:5001/api/";

    public static readonly string PATH_ARCHIVIO_SUPERENALOTTO = PATH_BASE + "Leggi/leggi_archivio_superenalotto";

    public async Task<struttura_archivio_superenalotto[]> Leggi_archivio_superenalotto(string anno)
    {
        var cont = await http.GetAsync(PATH_ARCHIVIO_SUPERENALOTTO + "/" + anno);
        if (cont.IsSuccessStatusCode)
        {
            return await cont.Content.ReadFromJsonAsync<struttura_archivio_superenalotto[]>();
        }
        return new struttura_archivio_superenalotto[0];
    }

    public class struttura_archivio_superenalotto
    {
        public string estrazione { get; set; }
        public string percorso { get; set; }
        public string numero1 { get; set; }
        public string numero2 { get; set; }
        public string numero3 { get; set; }
        public string numero4 { get; set; }
        public string numero5 { get; set; }
        public string numero6 { get; set; }
        public string jolly { get; set; }
        public string star { get; set; }
        public string valori { get; set; }
        public string v6 { get; set; }
        public string v51 { get; set; }
        public string v5 { get; set; }
        public string v4 { get; set; }
        public string v3 { get; set; }
        public string v2 { get; set; }
        public string s5 { get; set; }
        public string s4 { get; set; }
        public string s3 { get; set; }
        public string s2 { get; set; }
        public string s1 { get; set; }
        public string s0 { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
