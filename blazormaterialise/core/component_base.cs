  
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

        protected string _textcolor = "";
        protected string _backcolor = "";

        protected override async Task OnInitializedAsync(){
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

        
        

     

    }
}