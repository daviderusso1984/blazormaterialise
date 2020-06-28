


  function media_init(){
    var elems = document.querySelectorAll('.materialboxed');
    var options={};
    var instances = M.Materialbox.init(elems, options);
  }

  function carousel_init(){
    var elems = document.querySelectorAll('.carousel');
    var options={};
    var instances = M.Carousel.init(elems, options);
  }

  function floating_init(){
    var elems = document.querySelectorAll('.fixed-action-btn');
    var options={};
    var instances = M.FloatingActionButton.init(elems, options);
  }

  function navbar_init(){
    var elems = document.querySelectorAll('.sidenav');
    var options={};
    var instances = M.Sidenav.init(elems, options);
  }

  function collapsible_init(){
    var elems = document.querySelectorAll('.collapsible');
    var options={};
    var instances = M.Collapsible.init(elems, options);
  }

  function dropdown_init(){
    var elems = document.querySelectorAll('.dropdown-trigger');
    var options={};
    var instances = M.Dropdown.init(elems, options);
  } 

  function scrollspy(){
    var elems = document.querySelectorAll('.scrollspy');
    var options={};
    var instances = M.ScrollSpy.init(elems, options);
  }

  function toast(text,_class,rounded){
    if(rounded){
      M.toast({html: text , classes: 'rounded ' + _class})
    }else{
      M.toast({html: text , classes: _class})
    }       
  }

  function datepicker_init(forma,date){
    var elems = document.querySelectorAll('.datepicker');
    var options={format: forma , defaultDate:date , yearRange: 50};
    var instances = M.Datepicker.init(elems, options);
    
  }

  

  
  
