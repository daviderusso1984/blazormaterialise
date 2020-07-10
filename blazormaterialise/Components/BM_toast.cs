using Microsoft.JSInterop;

namespace blazormaterialise{

    public static class BM_toast{

        static IJSRuntime jss;
        static string _content;
        static bool _rounded;

        static string _class;

        public static void Inizialize(IJSRuntime js , string content , string Class , bool rounded ){
            jss = js;
            _content = content;
            _rounded = rounded;
            _class = Class;
        }

        public static async void show(){
            await jss.InvokeVoidAsync("toast", _content, _class, _rounded);

        }


    }
}