###Select DOM Elements
```JS
document.documentElement // <html>
document.body // body of the page
  HTMLLIElement // li
  HTMLAudioElement // audio
  HTMLAnchorElement // <a> has href property
  HTMLImageElement // <img> has src property
  HTMLInputElement // has value property
document // the entry point for the DOM API
innerHTML // returns full content as string (without the element)
outerHTML // returns full content as strung including the element
innerText / textContent // return as string the text content without the tags
```
####single element selection
```JS
var header = document.getElementById('header');
```
####select collection of elements
```JS
var inputs = document.getElementsByTagName('li');
var posts = document.getElementsByClassName('post-item');
var radiosGroup = document.getElementsByName('genders');
```
####predefined collections of elements
```JS
var links = document.links;
var forms = document.forms;
```
####using quiery Selector
```JS
//the element with id="header"
var header = document.querySelector('#header');
//li elements contained in element with id=main-nav
var navItems = document.querySelectorAll('#main-nav li');
```
####chain element selection
```JS
var wrapper = document.getElementById('wrapper');
// returns all div elements inside the element with id "wrapper"
var divsInWrapper = wrapper.getElementsByTagName('div');
```
###Node Lists
**A NodeList is a collection returned by the DOM selector methods:**
- getElementsByTagName(tagName)
- getElementsByName(name)
- getElementsByClassName(className)
- querySelectorAll(selector)
```JS
var divs = document.getElementsByTagName('div');
for(var i = 0, length = divs.length; i < length; i += 1){
   // do stuff with divs[i]…
}
```
###Static and Live node lists
- getElementsBy methods return a LiveNodeList - keeps track of elements all the time
- querySelectorAll returns a StaticNodeList - stores the elements az they were in the begining
