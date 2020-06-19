  
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace blazormaterialise{

    public abstract class component_base: ComponentBase{

       
        [Parameter]
        public string Class{get;set;}
        [Parameter]
        public string Backcolor{get;set;}
        [Parameter]
        public string Textcolor{get;set;}
        [Parameter]
        public enum_show Visibility{get;set;}
        

     

    }
}