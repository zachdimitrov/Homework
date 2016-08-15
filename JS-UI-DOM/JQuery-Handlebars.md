###Handlebars.js

Handlebars usage
```HTML
<h1>{{title}}</h1>   - Simple expression placeholder, we need JS object with property *title*
<h1>{{article.title}}</h1> - Dot seperated expression

<script id="entry-template" type="text/x-handlebars-template">  - use this to wrap templates in HTML file
{{{body}}} - if we don't want to escape html symbols - this returns working html
new Handlebars.SafeString(result) - another way to not escape HTML
``` 
Handlebars compilation
```js
var source = $("#entry-template").html(); //getting the template objec
var template = Handlebars.compile(source);  //compiling
var context = {title: "My New Post", body: "This is my first post!"}; //getting the info object
var html = template(context); //display the info wrapped in the template
```
Generating new helper
```JS
Handlebars.registerHelper('link', function(text, url) {
  text = Handlebars.Utils.escapeExpression(text); // escape manually
  url  = Handlebars.Utils.escapeExpression(url);  // because the result does not escape HTML

  var result = '<a href="' + url + '">' + text + '</a>';

  return new Handlebars.SafeString(result);
});
```
This is executed this way
```HTML
{{{link story}}}
```
