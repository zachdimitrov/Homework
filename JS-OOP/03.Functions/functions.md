## functions
#### declaration - 3 types
*function declaration*  
```js
function myFunc() {
    console.log(`my name is ${name}`);
}
```
*function expression*  
```js
var printMsg = function print() { console.log(msg); }
```
*function constructor*  
```js
var func = new Function("age", 'console.log("age")');
```
**arguments** - is the object that contains arguments of function  
**this** - represents context of function  
**return** - returns any type  