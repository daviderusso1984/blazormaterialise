


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

  function datepicker_init(forma,Y){
    
    
    var elems = document.querySelectorAll('.datepicker');
    var options={format: forma  ,  yearRange: Y };
    var instances = M.Datepicker.init(elems, options);
   
   
    
  }

  function timepicker_init(){
    var elems = document.querySelectorAll('.timepicker');
    var options={};
    var instances = M.Timepicker.init(elems, options);
  }

  function select_init(){
    var elems = document.querySelectorAll('select');
    var options={};
    var instances = M.FormSelect.init(elems, options);
  }

  function panzoom_init(){
    var element = document.querySelector('#scene');
    // and forward it it to panzoom.
    const panz = panzoom(element, {
      maxScale: 5,
      
    })
   
     //panzoom(element)
    
  }



  

  
  
