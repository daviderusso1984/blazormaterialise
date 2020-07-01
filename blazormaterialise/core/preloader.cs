namespace blazormaterialise{

    internal class preloader{

        internal string get_enum_color_circle(enum_color_circle_preloader en){
            switch (en)
            {
                case enum_color_circle_preloader.blue:
                return "spinner-blue-only";
                case enum_color_circle_preloader.green:
                return "spinner-green-only";
                case enum_color_circle_preloader.red:
                return "spinner-red-only";
                case enum_color_circle_preloader.yellow:
                return "spinner-yellow-only";
                default:
                return "";
            }
        }

        internal string get_enum_size_circle(enum_size_circle_preloader en){
            switch (en)
            {
                case enum_size_circle_preloader.big:
                return "big";
                case enum_size_circle_preloader.normal:
                return "";
                case enum_size_circle_preloader.small:
                return "small";
                default:
                return "";
            }
        }
    }
}