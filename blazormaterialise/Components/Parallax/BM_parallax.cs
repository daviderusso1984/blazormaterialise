using System;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace blazormaterialise
{
    public static class BM_parallax
    {
        public static async Task inizialize(IJSRuntime Js)
        {
            await Js.InvokeVoidAsync("parallax_init");
        }
    }
}
