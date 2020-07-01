namespace blazormaterialise
{

    internal class show
    {
        internal static string get_show(enum_show sh){
            switch (sh)
            {
                case enum_show.show:
                return "";
                case enum_show.hide:
                return "hide";
                case enum_show.hide_on_large_only:
                return "hide-on-large-only";
                case enum_show.hide_on_med_and_down:
                return "hide-on-med-and-down";
                case enum_show.hide_on_med_and_up:
                return "hide-on-med-and-up";
                case enum_show.hide_on_med_only:
                return "hide-on-med-only";
                case enum_show.hide_on_small_only:
                return "hide-on-small-only";
                case enum_show.show_on_large:
                return "show-on-large";
                case enum_show.show_on_medium:
                return "show-on-medium";
                case enum_show.show_on_medium_and_down:
                return "show-on-medium-and-down";
                case enum_show.show_on_medium_and_up:
                return "show-on-medium-and-up";
                case enum_show.show_on_small:
                return "show-on-small";               
                default:
                return "";
            }
        }
    }
}
