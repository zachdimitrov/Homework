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

