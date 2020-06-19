namespace blazormaterialise{
    public class grid{

        public string get_enun_col(enum_col col)
        {
            switch (col)
            {
                case enum_col.s1:
                    return "s1";
                case enum_col.s2:
                    return "s2";
                case enum_col.s3:
                    return "s3";
                case enum_col.s4:
                    return "s4";
                case enum_col.s5:
                    return "s5";
                case enum_col.s6:
                    return "s6";
                case enum_col.s7:
                    return "s7";
                case enum_col.s8:
                    return "s8";
                case enum_col.s9:
                    return "s9";
                case enum_col.s10:
                    return "s10";
                case enum_col.s11:
                    return "s11";
                case enum_col.s12:
                    return "s12";
                default:
                    return "";
            }
        }



    }
}