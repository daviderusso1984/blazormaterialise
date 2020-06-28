  
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace blazormaterialise{

    public abstract class component_base: ComponentBase{

       
       
        [Parameter]
        public string Class{get;set;}="";
        [Parameter]
        public string Backcolor{get;set;}
        [Parameter]
        public string Textcolor{get;set;}
        [Parameter]
        public enum_show Visibility{get;set;} = enum_show.show;
        [Parameter]
        public string Id{get;set;} = IdGenerator.Generate("Blazormaterialise_id_");
        [Parameter]
        public string Ref{get;set;} = "";

        protected component_base(){
            if(string.IsNullOrEmpty(Textcolor)){
                _textcolor = "text-black";
            }else{
                string[] spl = Textcolor.Split(null);
                spl[0] = spl[0] + "-text";
                if(spl.Length == 2){
                    spl[1] = "text-" + spl[1];
                    _textcolor = spl[0] + " " + spl[1];
                }else{
                    _textcolor = spl[0];
                }

            }
            if(string.IsNullOrEmpty(Backcolor)){
                _backcolor = "trasparent";
            }else{
                _backcolor = Backcolor;
            }
        }


        protected string _textcolor = "";
        protected string _backcolor = "";

       
        
        

     

    }

     public static class IdGenerator
    {
        public static string Generate(string prefix)
        {
            return prefix + Guid.NewGuid();
        }
    }
}