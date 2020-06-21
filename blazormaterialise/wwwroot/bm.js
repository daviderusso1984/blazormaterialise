


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

  
  
