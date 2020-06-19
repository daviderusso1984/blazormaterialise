using Microsoft.AspNetCore.Components;

namespace blazormaterialise{

    public abstract class css_base : component_base{
        
        [CascadingParameter]
        public theme Theme { get; set; }
    }
}