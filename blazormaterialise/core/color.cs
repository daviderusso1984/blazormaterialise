

namespace blazormaterialise
{
    public class color{

        public string get_color(enum_color color){
            switch (color)
            {
                //red
                case enum_color.red:
                return "red";
                case enum_color.red_darken_1:
                return "red darken-1";
                case enum_color.red_darken_2:
                return "red darken-2";
                case enum_color.red_darken_3:
                return "red darken-3";
                case enum_color.red_darken_4:
                return "red darken-4";
                case enum_color.red_lighten_1:
                return "red lighten-1";
                case enum_color.red_lighten_2:
                return "red lighten-2";
                case enum_color.red_lighten_3:
                return "red lighten-3";
                case enum_color.red_lighten_4:
                return "red lighten-4";
                case enum_color.red_lighten_5:
                return "red lighten-5";
                case enum_color.red_accent_1:
                return "red accent-1";
                 case enum_color.red_accent_2:
                return "red accent-2";
                 case enum_color.red_accent_3:
                return "red accent-3";
                 case enum_color.red_accent_4:
                return "red accent-4";
                //pink
                case enum_color.pink:
                return "#e91e63";
                case enum_color.pink_darken_1:
                return "#d81b60";
                case enum_color.pink_darken_2:
                return "#c2185b";
                case enum_color.pink_darken_3:
                return "#ad1457";
                case enum_color.pink_darken_4:
                return "#880e4f";
                case enum_color.pink_lighten_1:
                return "#ec407a";
                case enum_color.pink_lighten_2:
                return "#f06292";
                case enum_color.pink_lighten_3:
                return "#f48fb1";
                case enum_color.pink_lighten_4:
                return "#f8bbd0";
                case enum_color.pink_lighten_5:
                return "#fce4ec";
                case enum_color.pink_accent_1:
                return "#ff80ab";
                 case enum_color.pink_accent_2:
                return "#ff4081";
                 case enum_color.pink_accent_3:
                return "#f50057";
                 case enum_color.pink_accent_4:
                return "#c51162";
                //purple
                case enum_color.purple:
                return "#9c27b0";
                case enum_color.purple_darken_1:
                return "#8e24aa";
                case enum_color.purple_darken_2:
                return "#7b1fa2";
                case enum_color.purple_darken_3:
                return "#6a1b9a";
                case enum_color.purple_darken_4:
                return "#4a148c";
                case enum_color.purple_lighten_1:
                return "#ab47bc";
                case enum_color.purple_lighten_2:
                return "#ba68c8";
                case enum_color.purple_lighten_3:
                return "#ce93d8";
                case enum_color.purple_lighten_4:
                return "#e1bee7";
                case enum_color.purple_lighten_5:
                return "#f3e5f5";
                case enum_color.purple_accent_1:
                return "#ea80fc";
                 case enum_color.purple_accent_2:
                return "#e040fb";
                 case enum_color.purple_accent_3:
                return "#d500f9";
                 case enum_color.purple_accent_4:
                return "#aa00ff";
                //deep_purple
                case enum_color.deep_purple:
                return "#673ab7";
                case enum_color.deep_purple_darken_1:
                return "#5e35b1";
                case enum_color.deep_purple_darken_2:
                return "#512da8";
                case enum_color.deep_purple_darken_3:
                return "#4527a0";
                case enum_color.deep_purple_darken_4:
                return "#311b92";
                case enum_color.deep_purple_lighten_1:
                return "#7e57c2";
                case enum_color.deep_purple_lighten_2:
                return "#9575cd";
                case enum_color.deep_purple_lighten_3:
                return "#b39ddb";
                case enum_color.deep_purple_lighten_4:
                return "#d1c4e9";
                case enum_color.deep_purple_lighten_5:
                return "#ede7f6";
                case enum_color.deep_purple_accent_1:
                return "#b388ff";
                 case enum_color.deep_purple_accent_2:
                return "#7c4dff";
                 case enum_color.deep_purple_accent_3:
                return "#651fff";
                 case enum_color.deep_purple_accent_4:
                return "#6200ea";
                //indigo
                case enum_color.indigo:
                return "#3f51b5";
                case enum_color.indigo_darken_1:
                return "#3949ab";
                case enum_color.indigo_darken_2:
                return "#303f9f";
                case enum_color.indigo_darken_3:
                return "#283593";
                case enum_color.indigo_darken_4:
                return "#1a237e";
                case enum_color.indigo_lighten_1:
                return "#5c6bc0";
                case enum_color.indigo_lighten_2:
                return "#7986cb";
                case enum_color.indigo_lighten_3:
                return "#9fa8da";
                case enum_color.indigo_lighten_4:
                return "#c5cae9";
                case enum_color.indigo_lighten_5:
                return "#e8eaf6";
                case enum_color.indigo_accent_1:
                return "#8c9eff";
                 case enum_color.indigo_accent_2:
                return "#536dfe";
                 case enum_color.indigo_accent_3:
                return "#3d5afe";
                 case enum_color.indigo_accent_4:
                return "#304ffe";
                //blue
                case enum_color.blue:
                return "#2196f3";
                case enum_color.blue_darken_1:
                return "#1e88e5";
                case enum_color.blue_darken_2:
                return "#1976d2";
                case enum_color.blue_darken_3:
                return "#1565c0";
                case enum_color.blue_darken_4:
                return "#0d47a1";
                case enum_color.blue_lighten_1:
                return "#42a5f5";
                case enum_color.blue_lighten_2:
                return "#64b5f6";
                case enum_color.blue_lighten_3:
                return "#90caf9";
                case enum_color.blue_lighten_4:
                return "#bbdefb";
                case enum_color.blue_lighten_5:
                return "#e3f2fd";
                case enum_color.blue_accent_1:
                return "#82b1ff";
                 case enum_color.blue_accent_2:
                return "#448aff";
                 case enum_color.blue_accent_3:
                return "#2979ff";
                 case enum_color.blue_accent_4:
                return "#2962ff";
                //light_blue
                case enum_color.light_blue:
                return "#03a9f4";
                case enum_color.light_blue_darken_1:
                return "#039be5";
                case enum_color.light_blue_darken_2:
                return "#0288d1";
                case enum_color.light_blue_darken_3:
                return "#0277bd";
                case enum_color.light_blue_darken_4:
                return "#01579b";
                case enum_color.light_blue_lighten_1:
                return "#29b6f6";
                case enum_color.light_blue_lighten_2:
                return "#4fc3f7";
                case enum_color.light_blue_lighten_3:
                return "#81d4fa";
                case enum_color.light_blue_lighten_4:
                return "#b3e5fc";
                case enum_color.light_blue_lighten_5:
                return "#e1f5fe";
                case enum_color.light_blue_accent_1:
                return "#80d8ff";
                 case enum_color.light_blue_accent_2:
                return "#40c4ff";
                 case enum_color.light_blue_accent_3:
                return "#00b0ff";
                 case enum_color.light_blue_accent_4:
                return "#0091ea";
                //cyan
                case enum_color.cyan:
                return "#00bcd4";
                case enum_color.cyan_darken_1:
                return "#00acc1";
                case enum_color.cyan_darken_2:
                return "#0097a7";
                case enum_color.cyan_darken_3:
                return "#00838f";
                case enum_color.cyan_darken_4:
                return "#006064";
                case enum_color.cyan_lighten_1:
                return "#26c6da";
                case enum_color.cyan_lighten_2:
                return "#4dd0e1";
                case enum_color.cyan_lighten_3:
                return "#80deea";
                case enum_color.cyan_lighten_4:
                return "#b2ebf2";
                case enum_color.cyan_lighten_5:
                return "#e0f7fa";
                case enum_color.cyan_accent_1:
                return "#84ffff";
                 case enum_color.cyan_accent_2:
                return "#18ffff";
                 case enum_color.cyan_accent_3:
                return "#00e5ff";
                 case enum_color.cyan_accent_4:
                return "#00b8d4";
                //teal
                case enum_color.teal:
                return "#009688";
                case enum_color.teal_darken_1:
                return "#00897b";
                case enum_color.teal_darken_2:
                return "#00796b";
                case enum_color.teal_darken_3:
                return "#00695c";
                case enum_color.teal_darken_4:
                return "#004d40";
                case enum_color.teal_lighten_1:
                return "#26a69a";
                case enum_color.teal_lighten_2:
                return "#4db6ac";
                case enum_color.teal_lighten_3:
                return "#80cbc4";
                case enum_color.teal_lighten_4:
                return "#b2dfdb";
                case enum_color.teal_lighten_5:
                return "#e0f2f1";
                case enum_color.teal_accent_1:
                return "#a7ffeb";
                 case enum_color.teal_accent_2:
                return "#64ffda";
                 case enum_color.teal_accent_3:
                return "#1de9b6";
                 case enum_color.teal_accent_4:
                return "#00bfa5";
                //green
                case enum_color.green:
                return "#4caf50";
                case enum_color.green_darken_1:
                return "#43a047";
                case enum_color.green_darken_2:
                return "#388e3c";
                case enum_color.green_darken_3:
                return "#2e7d32";
                case enum_color.green_darken_4:
                return "#1b5e20";
                case enum_color.green_lighten_1:
                return "#66bb6a";
                case enum_color.green_lighten_2:
                return "#81c784";
                case enum_color.green_lighten_3:
                return "#a5d6a7";
                case enum_color.green_lighten_4:
                return "#c8e6c9";
                case enum_color.green_lighten_5:
                return "#e8f5e9";
                case enum_color.green_accent_1:
                return "#b9f6ca";
                 case enum_color.green_accent_2:
                return "#69f0ae";
                 case enum_color.green_accent_3:
                return "#00e676";
                 case enum_color.green_accent_4:
                return "#00c853";
                //light_green
                case enum_color.light_green:
                return "#8bc34a";
                case enum_color.light_green_darken_1:
                return "#7cb342";
                case enum_color.light_green_darken_2:
                return "#689f38";
                case enum_color.light_green_darken_3:
                return "#558b2f";
                case enum_color.light_green_darken_4:
                return "#33691e";
                case enum_color.light_green_lighten_1:
                return "#9ccc65";
                case enum_color.light_green_lighten_2:
                return "#aed581";
                case enum_color.light_green_lighten_3:
                return "#c5e1a5";
                case enum_color.light_green_lighten_4:
                return "#dcedc8";
                case enum_color.light_green_lighten_5:
                return "#f1f8e9";
                case enum_color.light_green_accent_1:
                return "#ccff90";
                 case enum_color.light_green_accent_2:
                return "#b2ff59";
                 case enum_color.light_green_accent_3:
                return "#76ff03";
                 case enum_color.light_green_accent_4:
                return "#64dd17";
                //lime
                case enum_color.lime:
                return "#f44336";
                case enum_color.lime_darken_1:
                return "#c0ca33";
                case enum_color.lime_darken_2:
                return "#afb42b";
                case enum_color.lime_darken_3:
                return "#9e9d24";
                case enum_color.lime_darken_4:
                return "#827717";
                case enum_color.lime_lighten_1:
                return "#d4e157";
                case enum_color.lime_lighten_2:
                return "#dce775";
                case enum_color.lime_lighten_3:
                return "#e6ee9c";
                case enum_color.lime_lighten_4:
                return "#f0f4c3";
                case enum_color.lime_lighten_5:
                return "#f9fbe7";
                case enum_color.lime_accent_1:
                return "#f4ff81";
                 case enum_color.lime_accent_2:
                return "#eeff41";
                 case enum_color.lime_accent_3:
                return "#c6ff00";
                 case enum_color.lime_accent_4:
                return "#aeea00";
                //yellow
                case enum_color.yellow:
                return "#ffeb3b";
                case enum_color.yellow_darken_1:
                return "#fdd835";
                case enum_color.yellow_darken_2:
                return "#fbc02d";
                case enum_color.yellow_darken_3:
                return "#f9a825";
                case enum_color.yellow_darken_4:
                return "#f57f17";
                case enum_color.yellow_lighten_1:
                return "#ffee58";
                case enum_color.yellow_lighten_2:
                return "#fff176";
                case enum_color.yellow_lighten_3:
                return "#fff59d";
                case enum_color.yellow_lighten_4:
                return "#fff9c4";
                case enum_color.yellow_lighten_5:
                return "#fffde7";
                case enum_color.yellow_accent_1:
                return "#ffff8d";
                 case enum_color.yellow_accent_2:
                return "#ffff00";
                 case enum_color.yellow_accent_3:
                return "#ffea00";
                 case enum_color.yellow_accent_4:
                return "#ffd600";
                //amber
                case enum_color.amber:
                return "#ffc107";
                case enum_color.amber_darken_1:
                return "#ffb300";
                case enum_color.amber_darken_2:
                return "#ffa000";
                case enum_color.amber_darken_3:
                return "#ff8f00";
                case enum_color.amber_darken_4:
                return "#ff6f00";
                case enum_color.amber_lighten_1:
                return "#ffca28";
                case enum_color.amber_lighten_2:
                return "#ffd54f";
                case enum_color.amber_lighten_3:
                return "#ffe082";
                case enum_color.amber_lighten_4:
                return "#ffecb3";
                case enum_color.amber_lighten_5:
                return "#fff8e1";
                case enum_color.amber_accent_1:
                return "#ffe57f";
                 case enum_color.amber_accent_2:
                return "#ffd740";
                 case enum_color.amber_accent_3:
                return "#ffc400";
                 case enum_color.amber_accent_4:
                return "#ffab00";
                //orange
                case enum_color.orange:
                return "#ff9800";
                case enum_color.orange_darken_1:
                return "#fb8c00";
                case enum_color.orange_darken_2:
                return "#f57c00";
                case enum_color.orange_darken_3:
                return "#ef6c00";
                case enum_color.orange_darken_4:
                return "#e65100";
                case enum_color.orange_lighten_1:
                return "#ffa726";
                case enum_color.orange_lighten_2:
                return "#ffb74d";
                case enum_color.orange_lighten_3:
                return "#ffcc80";
                case enum_color.orange_lighten_4:
                return "#ffe0b2";
                case enum_color.orange_lighten_5:
                return "#fff3e0";
                case enum_color.orange_accent_1:
                return "#ffd180";
                 case enum_color.orange_accent_2:
                return "#ffab40";
                 case enum_color.orange_accent_3:
                return "#ff9100";
                 case enum_color.orange_accent_4:
                return "#ff6d00";
                //deep_orange
                case enum_color.deep_orange:
                return "#ff5722";
                case enum_color.deep_orange_darken_1:
                return "#f4511e";
                case enum_color.deep_orange_darken_2:
                return "#e64a19";
                case enum_color.deep_orange_darken_3:
                return "#d84315";
                case enum_color.deep_orange_darken_4:
                return "#bf360c";
                case enum_color.deep_orange_lighten_1:
                return "#ff7043";
                case enum_color.deep_orange_lighten_2:
                return "#ff8a65";
                case enum_color.deep_orange_lighten_3:
                return "#ffab91";
                case enum_color.deep_orange_lighten_4:
                return "#ffccbc";
                case enum_color.deep_orange_lighten_5:
                return "#fbe9e7";
                case enum_color.deep_orange_accent_1:
                return "#ff9e80";
                 case enum_color.deep_orange_accent_2:
                return "#ff6e40";
                 case enum_color.deep_orange_accent_3:
                return "#ff3d00";
                 case enum_color.deep_orange_accent_4:
                return "#dd2c00";
                //brown
                case enum_color.brown:
                return "#795548";
                case enum_color.brown_darken_1:
                return "#6d4c41";
                case enum_color.brown_darken_2:
                return "#5d4037";
                case enum_color.brown_darken_3:
                return "#4e342e";
                case enum_color.brown_darken_4:
                return "#3e2723";
                case enum_color.brown_lighten_1:
                return "#8d6e63";
                case enum_color.brown_lighten_2:
                return "#a1887f";
                case enum_color.brown_lighten_3:
                return "#bcaaa4";
                case enum_color.brown_lighten_4:
                return "#d7ccc8";
                case enum_color.brown_lighten_5:
                return "#efebe9";               
                //grey
                case enum_color.grey:
                return "#9e9e9e";
                case enum_color.grey_darken_1:
                return "#757575";
                case enum_color.grey_darken_2:
                return "#616161";
                case enum_color.grey_darken_3:
                return "#424242";
                case enum_color.grey_darken_4:
                return "#212121";
                case enum_color.grey_lighten_1:
                return "#bdbdbd";
                case enum_color.grey_lighten_2:
                return "#e0e0e0";
                case enum_color.grey_lighten_3:
                return "#eeeeee";
                case enum_color.grey_lighten_4:
                return "#f5f5f5";
                case enum_color.grey_lighten_5:
                return "#fafafa";
                //blue_grey
                case enum_color.blue_grey:
                return "#607d8b";
                case enum_color.blue_grey_darken_1:
                return "#546e7a";
                case enum_color.blue_grey_darken_2:
                return "#455a64";
                case enum_color.blue_grey_darken_3:
                return "#37474f";
                case enum_color.blue_grey_darken_4:
                return "#263238";
                case enum_color.blue_grey_lighten_1:
                return "#78909c";
                case enum_color.blue_grey_lighten_2:
                return "#90a4ae";
                case enum_color.blue_grey_lighten_3:
                return "#b0bec5";
                case enum_color.blue_grey_lighten_4:
                return "#cfd8dc";
                case enum_color.blue_grey_lighten_5:
                return "#eceff1";
                case enum_color.black:
                return "#000000";
                case enum_color.white:
                return "#ffffff";
                case enum_color.trasparent:
                return "transparent";
               

                default:
                return "";
            }
        }


    }

    public enum enum_color{
        red, red_darken_1, red_darken_2, red_darken_3, red_darken_4,red_lighten_1,red_lighten_2,red_lighten_3,red_lighten_4,red_lighten_5,
        red_accent_1,red_accent_2,red_accent_3,red_accent_4,
         pink, pink_darken_1, pink_darken_2, pink_darken_3, pink_darken_4,pink_lighten_1,pink_lighten_2,pink_lighten_3,pink_lighten_4,pink_lighten_5,
        pink_accent_1,pink_accent_2,pink_accent_3,pink_accent_4,
         purple, purple_darken_1, purple_darken_2, purple_darken_3, purple_darken_4,purple_lighten_1,purple_lighten_2,purple_lighten_3,purple_lighten_4,purple_lighten_5,
        purple_accent_1,purple_accent_2,purple_accent_3,purple_accent_4,
         deep_purple, deep_purple_darken_1, deep_purple_darken_2, deep_purple_darken_3, deep_purple_darken_4,deep_purple_lighten_1,deep_purple_lighten_2,deep_purple_lighten_3,deep_purple_lighten_4,deep_purple_lighten_5,
        deep_purple_accent_1,deep_purple_accent_2,deep_purple_accent_3,deep_purple_accent_4,
         indigo, indigo_darken_1, indigo_darken_2, indigo_darken_3, indigo_darken_4,indigo_lighten_1,indigo_lighten_2,indigo_lighten_3,indigo_lighten_4,indigo_lighten_5,
        indigo_accent_1,indigo_accent_2,indigo_accent_3,indigo_accent_4,
         blue, blue_darken_1, blue_darken_2, blue_darken_3, blue_darken_4,blue_lighten_1,blue_lighten_2,blue_lighten_3,blue_lighten_4,blue_lighten_5,
        blue_accent_1,blue_accent_2,blue_accent_3,blue_accent_4,
         light_blue, light_blue_darken_1, light_blue_darken_2, light_blue_darken_3, light_blue_darken_4,light_blue_lighten_1,light_blue_lighten_2,light_blue_lighten_3,light_blue_lighten_4,light_blue_lighten_5,
        light_blue_accent_1,light_blue_accent_2,light_blue_accent_3,light_blue_accent_4,
          cyan, cyan_darken_1, cyan_darken_2, cyan_darken_3, cyan_darken_4,cyan_lighten_1,cyan_lighten_2,cyan_lighten_3,cyan_lighten_4,cyan_lighten_5,
        cyan_accent_1,cyan_accent_2,cyan_accent_3,cyan_accent_4,
         teal, teal_darken_1, teal_darken_2, teal_darken_3, teal_darken_4,teal_lighten_1,teal_lighten_2,teal_lighten_3,teal_lighten_4,teal_lighten_5,
        teal_accent_1,teal_accent_2,teal_accent_3,teal_accent_4,
         green, green_darken_1, green_darken_2, green_darken_3, green_darken_4,green_lighten_1,green_lighten_2,green_lighten_3,green_lighten_4,green_lighten_5,
        green_accent_1,green_accent_2,green_accent_3,green_accent_4,
         light_green, light_green_darken_1, light_green_darken_2, light_green_darken_3, light_green_darken_4,light_green_lighten_1,light_green_lighten_2,light_green_lighten_3,light_green_lighten_4,light_green_lighten_5,
        light_green_accent_1,light_green_accent_2,light_green_accent_3,light_green_accent_4,
         lime, lime_darken_1, lime_darken_2, lime_darken_3, lime_darken_4,lime_lighten_1,lime_lighten_2,lime_lighten_3,lime_lighten_4,lime_lighten_5,
        lime_accent_1,lime_accent_2,lime_accent_3,lime_accent_4,
         yellow, yellow_darken_1, yellow_darken_2, yellow_darken_3, yellow_darken_4,yellow_lighten_1,yellow_lighten_2,yellow_lighten_3,yellow_lighten_4,yellow_lighten_5,
        yellow_accent_1,yellow_accent_2,yellow_accent_3,yellow_accent_4,
         amber, amber_darken_1, amber_darken_2, amber_darken_3, amber_darken_4,amber_lighten_1,amber_lighten_2,amber_lighten_3,amber_lighten_4,amber_lighten_5,
        amber_accent_1,amber_accent_2,amber_accent_3,amber_accent_4,
         orange, orange_darken_1, orange_darken_2, orange_darken_3, orange_darken_4,orange_lighten_1,orange_lighten_2,orange_lighten_3,orange_lighten_4,orange_lighten_5,
        orange_accent_1,orange_accent_2,orange_accent_3,orange_accent_4,
         deep_orange, deep_orange_darken_1, deep_orange_darken_2, deep_orange_darken_3, deep_orange_darken_4,deep_orange_lighten_1,deep_orange_lighten_2,deep_orange_lighten_3,deep_orange_lighten_4,deep_orange_lighten_5,
        deep_orange_accent_1,deep_orange_accent_2,deep_orange_accent_3,deep_orange_accent_4,
         brown, brown_darken_1, brown_darken_2, brown_darken_3, brown_darken_4,brown_lighten_1,brown_lighten_2,brown_lighten_3,brown_lighten_4,brown_lighten_5,
        
         grey, grey_darken_1, grey_darken_2, grey_darken_3, grey_darken_4,grey_lighten_1,grey_lighten_2,grey_lighten_3,grey_lighten_4,grey_lighten_5,
       
         blue_grey, blue_grey_darken_1, blue_grey_darken_2, blue_grey_darken_3, blue_grey_darken_4,blue_grey_lighten_1,blue_grey_lighten_2,blue_grey_lighten_3,blue_grey_lighten_4,blue_grey_lighten_5,
       
         black, white, trasparent

    }

 
}