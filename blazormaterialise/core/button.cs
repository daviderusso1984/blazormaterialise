namespace blazormaterialise{
    public class button{

        public string get_button(enum_button but){
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
    }

    public enum enum_button{
        Raised , Floating, Flat , Large , Small
    }
}