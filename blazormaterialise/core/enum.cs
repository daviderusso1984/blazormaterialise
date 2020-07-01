using System;
namespace blazormaterialise
{
    public enum enum_button
    {
        Raised, Floating, Flat, Large, Small
    }

    public enum enum_icon_size
    {
        tiny , small , medium , large
    }

    public enum enum_show
    {
        show, //show all
        hide,   //Hidden for all Devices
        hide_on_small_only, //	Hidden for Mobile Only
        hide_on_med_only,   //Hidden for Tablet Only
        hide_on_med_and_down,   //Hidden for Tablet and Below
        hide_on_med_and_up, //Hidden for Tablet and Above
        hide_on_large_only, //Hidden for Desktop Only
        show_on_small,  //Show for Mobile Only
        show_on_medium, //Show for Tablet Only
        show_on_large,  //Show for Desktop Only
        show_on_medium_and_up,  //Show for Tablet and Above
        show_on_medium_and_down //Show for Tablet and Below
    }



    public enum enum_size_circle_preloader
    {
        big, normal, small
    }

    public enum enum_color_circle_preloader
    {
        red, yellow, blue, green
    }
    public enum enum_type_preloader
    {
        Linear, Circular, Circular_Flashing_Colors
    }

    public enum enum_date
    {
        ddmmyyyy, yyyymmdd
    }

    public enum enum_collection
    {
        Basic, Links
    }

    public enum enum_type_chip
    {
        Contacts, Tags
    }

    public enum enum_card_size
    {
        not, small, medium, large
    }

    public enum enum_color
    {
        not,
        red, red_darken_1, red_darken_2, red_darken_3, red_darken_4, red_lighten_1, red_lighten_2, red_lighten_3, red_lighten_4, red_lighten_5,
        red_accent_1, red_accent_2, red_accent_3, red_accent_4,
        pink, pink_darken_1, pink_darken_2, pink_darken_3, pink_darken_4, pink_lighten_1, pink_lighten_2, pink_lighten_3, pink_lighten_4, pink_lighten_5,
        pink_accent_1, pink_accent_2, pink_accent_3, pink_accent_4,
        purple, purple_darken_1, purple_darken_2, purple_darken_3, purple_darken_4, purple_lighten_1, purple_lighten_2, purple_lighten_3, purple_lighten_4, purple_lighten_5,
        purple_accent_1, purple_accent_2, purple_accent_3, purple_accent_4,
        deep_purple, deep_purple_darken_1, deep_purple_darken_2, deep_purple_darken_3, deep_purple_darken_4, deep_purple_lighten_1, deep_purple_lighten_2, deep_purple_lighten_3, deep_purple_lighten_4, deep_purple_lighten_5,
        deep_purple_accent_1, deep_purple_accent_2, deep_purple_accent_3, deep_purple_accent_4,
        indigo, indigo_darken_1, indigo_darken_2, indigo_darken_3, indigo_darken_4, indigo_lighten_1, indigo_lighten_2, indigo_lighten_3, indigo_lighten_4, indigo_lighten_5,
        indigo_accent_1, indigo_accent_2, indigo_accent_3, indigo_accent_4,
        blue, blue_darken_1, blue_darken_2, blue_darken_3, blue_darken_4, blue_lighten_1, blue_lighten_2, blue_lighten_3, blue_lighten_4, blue_lighten_5,
        blue_accent_1, blue_accent_2, blue_accent_3, blue_accent_4,
        light_blue, light_blue_darken_1, light_blue_darken_2, light_blue_darken_3, light_blue_darken_4, light_blue_lighten_1, light_blue_lighten_2, light_blue_lighten_3, light_blue_lighten_4, light_blue_lighten_5,
        light_blue_accent_1, light_blue_accent_2, light_blue_accent_3, light_blue_accent_4,
        cyan, cyan_darken_1, cyan_darken_2, cyan_darken_3, cyan_darken_4, cyan_lighten_1, cyan_lighten_2, cyan_lighten_3, cyan_lighten_4, cyan_lighten_5,
        cyan_accent_1, cyan_accent_2, cyan_accent_3, cyan_accent_4,
        teal, teal_darken_1, teal_darken_2, teal_darken_3, teal_darken_4, teal_lighten_1, teal_lighten_2, teal_lighten_3, teal_lighten_4, teal_lighten_5,
        teal_accent_1, teal_accent_2, teal_accent_3, teal_accent_4,
        green, green_darken_1, green_darken_2, green_darken_3, green_darken_4, green_lighten_1, green_lighten_2, green_lighten_3, green_lighten_4, green_lighten_5,
        green_accent_1, green_accent_2, green_accent_3, green_accent_4,
        light_green, light_green_darken_1, light_green_darken_2, light_green_darken_3, light_green_darken_4, light_green_lighten_1, light_green_lighten_2, light_green_lighten_3, light_green_lighten_4, light_green_lighten_5,
        light_green_accent_1, light_green_accent_2, light_green_accent_3, light_green_accent_4,
        lime, lime_darken_1, lime_darken_2, lime_darken_3, lime_darken_4, lime_lighten_1, lime_lighten_2, lime_lighten_3, lime_lighten_4, lime_lighten_5,
        lime_accent_1, lime_accent_2, lime_accent_3, lime_accent_4,
        yellow, yellow_darken_1, yellow_darken_2, yellow_darken_3, yellow_darken_4, yellow_lighten_1, yellow_lighten_2, yellow_lighten_3, yellow_lighten_4, yellow_lighten_5,
        yellow_accent_1, yellow_accent_2, yellow_accent_3, yellow_accent_4,
        amber, amber_darken_1, amber_darken_2, amber_darken_3, amber_darken_4, amber_lighten_1, amber_lighten_2, amber_lighten_3, amber_lighten_4, amber_lighten_5,
        amber_accent_1, amber_accent_2, amber_accent_3, amber_accent_4,
        orange, orange_darken_1, orange_darken_2, orange_darken_3, orange_darken_4, orange_lighten_1, orange_lighten_2, orange_lighten_3, orange_lighten_4, orange_lighten_5,
        orange_accent_1, orange_accent_2, orange_accent_3, orange_accent_4,
        deep_orange, deep_orange_darken_1, deep_orange_darken_2, deep_orange_darken_3, deep_orange_darken_4, deep_orange_lighten_1, deep_orange_lighten_2, deep_orange_lighten_3, deep_orange_lighten_4, deep_orange_lighten_5,
        deep_orange_accent_1, deep_orange_accent_2, deep_orange_accent_3, deep_orange_accent_4,
        brown, brown_darken_1, brown_darken_2, brown_darken_3, brown_darken_4, brown_lighten_1, brown_lighten_2, brown_lighten_3, brown_lighten_4, brown_lighten_5,

        grey, grey_darken_1, grey_darken_2, grey_darken_3, grey_darken_4, grey_lighten_1, grey_lighten_2, grey_lighten_3, grey_lighten_4, grey_lighten_5,

        blue_grey, blue_grey_darken_1, blue_grey_darken_2, blue_grey_darken_3, blue_grey_darken_4, blue_grey_lighten_1, blue_grey_lighten_2, blue_grey_lighten_3, blue_grey_lighten_4, blue_grey_lighten_5,

        black, white, trasparent

    }

}
