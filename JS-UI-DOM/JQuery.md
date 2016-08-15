###Jquery.js
```HTML
<script src="jquery.js"></script> // load Jquery
```
```JS
$( document ).ready(function() {
    // this will execute when document is fully loaded
});
$(function() {
    // another way to use it
});
```
####Getters and Setters
```JS
$('#item').attr('style', 'display: inline-block'); // change attributes of an object
var style = $('#item').attr('style'); // if not set value - returns it
```
####Selectors
```JS
var $divs = $('div');  // selects elements with this tag - multiple elements like array
$( ".myClass" ); // select by class - multiple
$( "#someId" ); // select by CSS selector - ID
$( "#contents ul.people li" ); // complex CSS selector
$( "div.myClass, ul.people" ); // with comma seperated CSS
$( "input[name='first_name']" ); // by attribute
$( "a.external:first" ); // pseudo selectors
$( "div:gt(2)" ); // select all but first 2 divs
```
####Refining selections
```JS
// Refining selections.
$( "div.foo" ).has( "p" );         // div.foo elements that contain <p> tags
$( "h1" ).not( ".bar" );           // h1 elements that don't have a class of bar
$( "ul li" ).filter( ".current" ); // unordered list items with class of current
$( "ul li" ).first();              // just the first unordered list item
$( "ul li" ).eq( 5 );              // the sixth
$( "form :checked" );              // checked, selected, and when radio buttons are checked
$( "form :disabled" );      $form.filter( ":disabled" )       // 
$( "form :enabled" );
$( "form :input" );
$( "form :selected" );
:password // pseudo selectors by type
:reset
:radio
:text
:submit
:checkbox
:button
:image
:file
```
####Methods for selection - changing affects all elements in selection
```JS
$( "h1" ).html( "hello world" ); //sets all the h1 elements to "hello world"
$( "h1" ).html(); // will return "hello world", chaining dont work!
$( "#content" ) // this is method chaining
    .find( "h3" ) // returns all h3
    .eq( 2 ) // the 3-rd one
    .html( "new text for the third h3!" ); //adds to html
    .end() // restores back to original selection before changing html
```
*Other methods*

```.text()``` – Get or set the text contents; HTML will be stripped.  
```.attr()``` – Get or set the value of the provided attribute.  
```.width()``` – Get or set the width in pixels of the first element in the selection as an integer.  
```.height()``` – Get or set the height in pixels of the first element in the selection as an integer.  
```.position()``` – Get an object with position information for the first element in the selection, relative to its first positioned ancestor. This is a getter only.  
```.val()``` – Get or set the value of form elements.  

####Moving Copying and Removing Elements
```.insertAfter()``` - places the selected element(s) after the element provided as an argument  
```.after()``` - places the element provided as an argument after the selected element  
```.insertBefore()``` - places before argument  
```.before()``` - places argument element before selection  
```.appendTo()``` - adds as last child element to argument  
```.append()``` - adds arguments az last child elements  
```.prependTo()``` - adds as first child element to argument  
```.prepend()``` - adds arguments az first child elements   
*clone remove detach empty*  
```.clone()``` - creates a copy of element - ```$( "#myList li:first" ).clone().appendTo( "#myList" );```    
```.remove()``` - delete from DOM   
```.detach()``` - detach from DOM but keep as var   
```.empty()``` - dispose elements innerHTML   

####Creating elements
```JS
$( "<p>This is a new paragraph</p>" ); // Creating new elements from an HTML string
$( "<a/>", {
    html: "This is a <strong>new</strong> link",
    "class": "new",
    href: "foo.html"
}); // This is creating element with properties 
``` 

####Traversing the DOM
```JS
// Parents and children
$( "span.subchild" ).parent();
$( "span.subchild" ).parents( "div.parent" );
$( "span.subchild" ).parentsUntil( "div.grandparent" );
$( "span.subchild" ).closest( "div" );
$( "div.grandparent" ).children( "div" );
// Siblings
$( "div.parent" ).next();
$( "div.parent" ).prev();
$( "div.parent" ).nextAll();
$( "div.parent" ).nextAll().first();
$( "div.parent" ).nextAll().last();
$( "div.Parent2" ).prevAll();
$( "div.Parent2" ).prevAll().first();
$( "div.Parent2" ).prevAll().last();
$( "div.parent" ).siblings();
```

####Styling and CSS
```JS
$( "h1" ).css( "font-size" ); // Also works "fontSize" - getting property
$( "h1" ).css( "fontSize", "100px" ); // individual property
$( "h1" ).css({                       // multiple properties
    fontSize: "100px",
    color: "red"
});
h1.addClass( "big" );
h1.removeClass( "big" );
h1.toggleClass( "big" );  // removed if added and opposite
h1.hasClass( "big" ); // true or false 
$( "h1" ).width( "50px" );
$( "h1" ).height( "50px" ); // if no argument works as getter
$( "h1" ).position();
```

####Data methods

```JS
$( "#myDiv" ).data( "keyName", { foo: "bar" } ); // Storing and retrieving data related to an element.
$( "#myDiv" ).data( "keyName" );                 // Returns { foo: "bar" }
```
####Utility methods
```JS
$.trim( "    lots of extra whitespace    " ); // trims whitespaces
$.each([10, 20, 30, 40], function(index, value) { console.log(index + ":" + value + "<br>" }); // returnes 4 lines like (0:10, 1:20...)
$.map() //  works on plain JavaScript arrays while .map() don't
var myArray = [ 1, 2, 3, 5 ];
if ( $.inArray( 4, myArray ) !== -1 ) { console.log( "found it!" ); } // returns element in array
var newObject = $.extend( firstObject, secondObject ); // adds second object to first, firstObject is also changed
var newObject = $.extend( {}, firstObject, secondObject ); // keeps the first object and creates ne independant
$.proxy() // Returns a function that will always run in the provided scope
```

####Testing Types
```JS
$.isArray([]); // true
$.isFunction(function() {}); // true
$.isNumeric(3.14); // true
$.type( true ); // "boolean"
$.type( /test/ ); // "regexp"
```

###Events
```JS
$( "p" ).click(function() { console.log( "You clicked a paragraph!" ); }); // standard way to use events
// .focus() .blur() .change() are similar
$( "p" ).on( "click", function() { console.log( "click" ); }); // same using on
$( "body" ).on( "click", "button", function( event ) { alert( "Hello." ); }); // attach to parent
```
####Event handler functions
```JS
.preventDefault() // prevents default action
.stopPropagation() // stops bubbling
```
[Other methods](http://www.w3schools.com/jquery/jquery_ref_events.asp)
[Events](http://www.w3schools.com/jsref/dom_obj_event.asp(
