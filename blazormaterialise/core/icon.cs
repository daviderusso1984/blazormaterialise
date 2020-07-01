using System;
namespace blazormaterialise
{
    internal class icon
    {
        internal static string get_icon_size(enum_icon_size ic)
        {
            switch (ic)
            {
                case enum_icon_size.large:
                    return "large";
                case enum_icon_size.medium:
                    return "medium";
                case enum_icon_size.small:
                    return "small";
                case enum_icon_size.tiny:
                    return "tiny";
                default:
                    return "";
            }
        }
    } 
}
