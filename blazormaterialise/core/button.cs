namespace blazormaterialise{
    internal static class button{

        internal static string get_button(enum_button but){
            switch (but)
            {
                case enum_button.Raised:
                return "btn";
                case enum_button.Floating:
                return "btn-floating btn-large";
                case enum_button.Flat:
                return "btn-flat";
                case enum_button.Large:
                return "btn-large";
                case enum_button.Small:
                return "btn-small";
                default:
                return "";
            }
        }

        internal static string get_wave(enum_style_wave sty){
            switch (sty)
            {
                case enum_style_wave.light:
                return "waves-light";
                case enum_style_wave.green:
                return "waves-green";
                case enum_style_wave.orange:
                return "waves-orange";
                case enum_style_wave.purple:
                return "waves-purple";
                case enum_style_wave.red:
                return "waves-red";
                case enum_style_wave.teal:
                return "waves-teal";
                case enum_style_wave.yellow:
                return "waves-yellow";
                default:
                return "";
            }
        }

       
    }

   
}