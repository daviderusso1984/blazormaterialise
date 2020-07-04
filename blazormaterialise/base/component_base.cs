  
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace blazormaterialise{

    public abstract class component_base: ComponentBase, IDisposable
    {

       
       
        [Parameter]
        public string Class{get;set;}="";
       
        [Parameter]
        public enum_color Backcolor { get; set; } = enum_color.not;
        [Parameter]
        public enum_color Textcolor { get; set; } = enum_color.not;
        [Parameter]
        public enum_show Visibility{get;set;} = enum_show.show;
        [Parameter]
        public string Id{get;set;} = IdGenerator.Generate("Blazormaterialise_id_");
       

        [Parameter]
        public string Data_target { get; set; }

        public void Dispose()
        {
            Disposed = true;
        }

        protected bool Disposed { get; private set; }

        protected void InvokeStateHasChanged()
        {
            InvokeAsync(() =>
            {
                try
                {
                    if (!Disposed)
                    {
                        StateHasChanged();
                    }
                }
                catch (Exception e)
                {
                    //
                }
            });
        }
    }

     public static class IdGenerator
    {
        public static string Generate(string prefix)
        {
            return prefix + Guid.NewGuid();
        }
    }
}