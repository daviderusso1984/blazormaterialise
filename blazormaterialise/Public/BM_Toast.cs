using Microsoft.JSInterop;

namespace blazormaterialise{
    public class BM_toast{

        IJSRuntime jss;
        string _content;
        bool _rounded;

        string _class;
        public BM_toast(IJSRuntime js , string content , string Class , bool rounded ){
            jss = js;
            _content = content;
            _rounded = rounded;
            _class = Class;
        }

        public async void show(){
            //await jss.InvokeVoidAsync("toast_init");
            if(_rounded){
                await jss.InvokeVoidAsync("Materialize.toast({html: '" + _content + "', classes: 'rounded' })");
            }else{
                await jss.InvokeVoidAsync("toast",_content,_class,_rounded);
            }
            
        }


    }
}