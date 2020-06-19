namespace blazormaterialise
{

    public class show
    {
        public string get_show(enum_show sh){
            switch (sh)
            {
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

public enum enum_show
{
    hide,	//Hidden for all Devices
    hide_on_small_only, //	Hidden for Mobile Only
    hide_on_med_only,   //Hidden for Tablet Only
    hide_on_med_and_down,   //Hidden for Tablet and Below
    hide_on_med_and_up, //Hidden for Tablet and Above
    hide_on_large_only, //Hidden for Desktop Only
    show_on_small,  //Show for Mobile Only
    show_on_medium, //Show for Tablet Only
    show_on_large,  //Show for Desktop Only
    show_on_medium_and_up,  //Show for Tablet and Above
    show_on_medium_and_down	//Show for Tablet and Below
}