using System;
using Microsoft.JSInterop;

namespace blazormaterialise.Components
{
    public static class BM_scrollspy
    {

        //scrollspy
        public static string Scrollspy = "scrollspy";


        public static async void Inizialize(IJSRuntime Js)
        {
            await Js.InvokeVoidAsync("scrollspy_init");
        }
    }
}
