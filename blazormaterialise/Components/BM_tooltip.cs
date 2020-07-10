using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace blazormaterialise
{
    public static class BM_tooltip
    {
       

        public static async Task inizialize(IJSRuntime Js)
        {
            await Js.InvokeVoidAsync("tooltip_init");
        }
    }
}
