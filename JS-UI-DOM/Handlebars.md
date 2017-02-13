###Handlebars.js

Simple notation (if we have oproperty title in the object)
```HTML
<h1>{{title}}</h1>   - Simple expression placeholder, we need JS object with property *title*
```

Dot seperated expression (for article property that has tutle sub-property)
```HTML
<h1>{{article.title}}</h1>
```

Iterating an array (iterates over each item of array)
```HTML
{{#each}}
  <div>
    {{body}}
  </div>
{{/each}}
```

Iterating an object (iterates over each property)
```HTML
{{#each objectName}}
  <div>
    {{body}}
  </div>
{{/each}}
```

Segment-Literal Iteration Notation (same as ```articles[10]['#comments']``` in JS)
```HTML
{{#each articles.[10].[#comments]}}
  <h1>{{subject}}</h1>
  <div>
    {{body}}
  </div>
{{/each}}
```


Wrap template in the HTML file
```HTML
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
Handlebars.registerHelper('link', function(obj) {
  text = Handlebars.Utils.escapeExpression(this.text); // escape manually
  url  = Handlebars.Utils.escapeExpression(this.url);  // because the result does not escape HTML
  var result = '<a href="' + url + '">' + text + '</a>';
  return new Handlebars.SafeString(result);
});
```
This is executed this way
```HTML
{{{link story}}}
// or if we have multiple objects
{{#each data}}
    <li>{{link url text}}</li>
{{/each}} 
// if statement 
{{#if author}}
    <h1>{{link story}}</h1>
{{/if}}
```
Using **options.fn** to create a helper - takes this as a regular template and uses it in the helper
```JS
Handlebars.registerHelper('bold', function(options) {
  return new Handlebars.SafeString(
      '<div class="mybold">'
      + options.fn(this)
      + '</div>');
});
// use it like this
{{#bold}}{{body}}{{/bold}}
```
Using **with** helper
```JS
Handlebars.registerHelper('with', function(context, options) {
  return options.fn(context);
});
{{#with story}}
    <div class="intro">{{{intro}}}</div>
    <div class="body">{{{body}}}</div>
{{/with}}
```
Using **if** statement
```JS
{{#if isActive}}
  <img src="star.gif" alt="Active">
{{else}} // this is optional
  <img src="cry.gif" alt="Inactive">
{{/if}}
```
