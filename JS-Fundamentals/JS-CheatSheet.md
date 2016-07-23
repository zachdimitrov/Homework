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
let PI = Math.PI; // 3.141592653589793
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
let minValue = Number.MIN_VALUE; // 5e-324
let maxValue = Number.MAX_VALUE; // 1.79e+308
```
**Converting numbers**
```JS
var valueDouble = 8.75;
var valueInt = valueDouble | 0; // 8 - converts floating point to integer
var roundedInt = (valueDouble + 0.5) | 0; // 9 - rounded
var str = '1234';
var i = str | 0; // number 1234
let numberString = '123'
Number('123.3') -> returns 123.3
'123.3' * 1 -> returns 123.3
+'123.3' -> returns 123.3
console.log(parseInt(numberString)); // prints 123
let floatString = '12.3';
console.log(parseFloat(floatString)); // prints 12.3
let str = '123Hello';
console.log(parseInt(str)); // prints 123
console.log(typeof x); // pokazva kakvy e tipa na stoinostta \X
const depth = 250; // konstanta
a = 5; // tova e globalna promenliva kato winfow.a = 5; ne se pravi!
```
**Strings**
```JS
let s = 'Welcome to JavaScript';
let name = 'John' + ' ' + 'Doe';
let greeting = `${s}, ${name}`; // nov zapis podobno na C#
```
##Operators and expressions
**Category	Operators**
Arithmetic	+ - * / % ++ --
Logical	&& || ^ !
Binary	& | ^ ~ << >> >>>
Comparison	== != < > <= >= === !==
Assignment	= += -= *= /= %= |= ^= <<= >>=
Concatenation	+
Other	. [] () ?: new in , delete void typeof instanceof

##Conditional statemenst
**if** and **if-else** - statement
```JS
var str = '1c23';
if(!(+str)){ // if str is not a number, +str is NaN
  throw new Error('str is not a Number!');
  } else {
  str = 5;
  }
```
**switch - case** - statement
```JS
switch (false) {
  case !!score: // true when score is NaN, if you miss a brake the next true code will be executed
  case !(score < 2 || score > 6): console.log('Invalid score'); break;
  case !(score < 3.5): console.log('Poor' + score); break;
  case !(score < 4.5): console.log('Good ' + score); break;
  /* case for score < 5.5 */
  default: console.log('Excellent ' + score); break;
}
```
