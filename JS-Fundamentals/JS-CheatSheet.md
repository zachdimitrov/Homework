##Introduction
**zakachane na JS za HTML**
```HTML
<scriрt src="scripts.js" type="text/javascript">
<!-- code placed here will not be executed! -->
</scriрt>
```
**JS Examples - Pop-up boxes**
```JS
alert("Some text here");
confirm("Are you sure?");
prompt ("enter amount", 10);
```
**Browser built-in objects**
- window
- document
- screen
- browser

**Math object**
```JS
var x = Math.random(); // random value
x = Math.floor(x); // smallest number
```
**Date object**
```JS
var now = new Date(); // current date time
  var hour = now.getHours();
  var min = now.getMinutes();
  var sec = now.getSeconds();
var timer = setTimeout(bang, 5000); // execute aftet 5 sec
clearTimeout(timer); // clear timer
var timer = setInterval(clock, 1000); // execute in 1 sec intervals
clearInterval(timer); // clear timer
```
**Console object**
- debug(message)
- info(message)
- log(message)
- warn(message)
- error(message)

##Data types and viariables

**Declare variables**
```JS
var count = 5 // var se vijda v celiq function scope, bez znachenie dlai e v zatvoren blok kato cikal
let mark = 5.25 // let e vidima samo v konkretniq blok kato cikyl naprimer
var value = 3.14159;
value = new Number(100); // Number { 100 } wrapped as an object of type Number
```
**Converting numbers**
```JS
var valueDouble = 8.75;
var valueInt = valueDouble | 0; // 8 - converts floating point to integer
var roundedInt = (valueDouble + 0.5) | 0; // 9 - rounded
```
