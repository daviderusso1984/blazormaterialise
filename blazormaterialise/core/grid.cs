namespace blazormaterialise{
    public class grid{

        public string get_enun_col(enum_col col)
        {
            switch (col)
            {
                case enum_col.c1:
                    return "1";
                case enum_col.c2:
                    return "2";
                case enum_col.c3:
                    return "3";
                case enum_col.c4:
                    return "4";
                case enum_col.c5:
                    return "5";
                case enum_col.c6:
                    return "6";
                case enum_col.c7:
                    return "7";
                case enum_col.c8:
                    return "8";
                case enum_col.c9:
                    return "9";
                case enum_col.c10:
                    return "10";
                case enum_col.c11:
                    return "11";
                case enum_col.c12:
                    return "12";
                case enum_col.c0:
                    return "";
                default:
                    return "";
            }
        }



    }
}