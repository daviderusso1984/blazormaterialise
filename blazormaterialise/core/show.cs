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
                case enum_show.hide_desktop:
                return "hide-on-large-only";
                case enum_show.hide_tablet_mobile:
                return "hide-on-med-and-down";
                case enum_show.hide_tablet_desktop:
                return "hide-on-med-and-up";
                case enum_show.hide_tablet:
                return "hide-on-med-only";
                case enum_show.hide_mobile:
                return "hide-on-small-only";
                case enum_show.show_desktop:
                return "show-on-large";
                case enum_show.show_tablet:
                return "show-on-medium";
                case enum_show.show_tablet_mobile:
                return "show-on-medium-and-down";
                case enum_show.show_tablet_desktop:
                return "show-on-medium-and-up";
                case enum_show.show_mobile:
                return "show-on-small";               
                default:
                return "";
            }
        }
    }
}
