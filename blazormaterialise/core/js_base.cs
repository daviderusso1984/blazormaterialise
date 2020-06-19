using Microsoft.AspNetCore.Components;

namespace blazormaterialise{

    public abstract class js_base : component_base{
        
        [CascadingParameter]
        public theme Theme { get; set; }
    }
}