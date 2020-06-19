  
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace blazormaterialise{

    public abstract class grid_base: ComponentBase{

        
        [Parameter]
        public string Class{get;set;}

       

    }
}