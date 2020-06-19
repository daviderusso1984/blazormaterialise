using System;

namespace blazormaterialise
{
    public class theme{

        public string Background{get;set;}
       
        public string text_color{get;set;}

        public event EventHandler<EventArgs> Changed;

        public string get_theme(){
            string th="";
            if(!string.IsNullOrEmpty(Background)){
                th += Background + " ";
            }
            if(!string.IsNullOrEmpty(text_color)){
                string[] spl = text_color.Split(null); //split 
                if(spl.Length == 2){
                    th += spl[0] + "-text text-" + spl[1] + " ";
                }
            }
            return th;
        } 


        public void ThemeHasChanged()
        {
            OnChanged();
        }

         protected virtual void OnChanged()
        {
            Changed?.Invoke(this, EventArgs.Empty);
        }

    }
}

