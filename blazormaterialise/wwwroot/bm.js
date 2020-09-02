
//media

function bm_media(id) {
    var elems = document.getElementById(id);
    var options = {};
    var instances = M.Materialbox.init(elems, options);
}

//slider

function bm_slider() {
    var elems = document.querySelectorAll('.slider');
    var options = {};
    var instances = M.Slider.init(elems, options);
}


function bm_carousel(id) {
    var elems = document.getElementById(id);
    var options = {};
    var instances = M.Carousel.init(elems, options);
}

function bm_floating(id) {
    var elems = document.getElementById(id);
    var options = {};
    var instances = M.FloatingActionButton.init(elems, options);
}

function bm_navbar(id) {
    var elems = document.getElementById(id);
    var options = {};
    var instances = M.Sidenav.init(elems, options);
}

//collapsible

function bm_collapsible(id) {
    var elems = document.getElementById(id);
    var options = {};
    var instances = M.Collapsible.init(elems, options);
}

function bm_collapsible_open(id, number_item) {
    var elems = document.getElementById(id);
    var instance = M.Collapsible.getInstance(elems);
    instance.open(number_item);
}

function bm_collapsible_close(id, number_item) {
    var elems = document.getElementById(id);
    var instance = M.Collapsible.getInstance(elems);
    instance.close(number_item);
}



function bm_dropdown() {
    var elems = document.querySelectorAll('.dropdown-trigger');
    var options = {};
    var instances = M.Dropdown.init(elems, options);
}

function scrollspy() {
    var elems = document.querySelectorAll('.scrollspy');
    var options = {};
    var instances = M.ScrollSpy.init(elems, options);
}

function toast(text, _class, rounded) {
    if (rounded) {
        M.toast({ html: text, classes: 'rounded ' + _class })
    } else {
        M.toast({ html: text, classes: _class })
    }
}

function datepicker_init(forma, Y) {


    var elems = document.querySelectorAll('.datepicker');
    var options = { format: forma, yearRange: Y };
    var instances = M.Datepicker.init(elems, options);



}

function timepicker_init() {
    var elems = document.querySelectorAll('.timepicker');
    var options = {};
    var instances = M.Timepicker.init(elems, options);
}

function select_init() {
    var elems = document.querySelectorAll('select');
    var options = {};
    var instances = M.FormSelect.init(elems, options);
}

//sidebar

function bm_sidebar(id) {
    var elems = document.getElementById(id);
    var options = {};
    var instances = M.Sidenav.init(elems, options);
}

function sidebar_open(id) {
    var elems = document.getElementById(id);
    var instance = M.Sidenav.getInstance(elems);
    instance.open();
}

function sidebar_close(id) {
    var elems = document.getElementById(id);
    var instance = M.Sidenav.getInstance(elems);
    instance.close();
}

//featurediscovery

function featurediscovery_init() {
    var elems = document.querySelectorAll('.tap-target');
    var options = {};
    var instances = M.TapTarget.init(elems, options);
}

function featurediscovery_show(id) {
    var elems = document.getElementById(id);
    var instance = M.TapTarget.getInstance(elems);
    instance.open();
}

function featurediscovery_close(id) {
    var elems = document.getElementById(id);
    var instance = M.TapTarget.getInstance(elems);
    instance.close();
}


//modal


function modal_init() {
    var elems = document.querySelectorAll('.modal');
    var options = {};
    var instances = M.Modal.init(elems, options);
}

function modal_open(id) {
    var elems = document.getElementById(id);
    var instance = M.Modal.getInstance(elems);
    instance.open();
}

function modal_close(id) {
    var elems = document.getElementById(id);
    var instance = M.Modal.getInstance(elems);
    instance.close();
}

//tabs

function tabs_init(id) {
    var elems = document.getElementById(id);
    var options = {};
    var instance = M.Tabs.init(elems, options);
}

//tooltip

function tooltip_init() {
    var elems = document.querySelectorAll('.tooltipped');
    var options = {};
    var instances = M.Tooltip.init(elems, options);
}

//scrollspy

function scrollspy_init() {
    var elems = document.querySelectorAll('.scrollspy');
    var options = {};
    var instances = M.ScrollSpy.init(elems, options);
}

//parallax

function parallax_init() {
    var elems = document.querySelectorAll('.parallax');
    var options = {};
    var instances = M.Parallax.init(elems, options);
}

//range

function range_init(){
    var array_of_dom_elements = document.querySelectorAll("input[type=range]");
    M.Range.init(array_of_dom_elements);
}


//input
function input_init() {
    M.updateTextFields();
}





