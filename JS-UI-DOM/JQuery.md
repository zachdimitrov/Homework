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
$('#item').html('some text'); // adds text to html
var content = $('#item').html(); // getsh the HTML content
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

```
