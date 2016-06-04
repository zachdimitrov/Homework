### Simple functions
```JS
function wrt(iid, txt) {
    var x = document.getElementById(iid);
    x.innerHTML = txt;
}

function showS(id) {
    document.getElementById(id).style.display = 'block';
    document.getElementById(id).style.zIndex = -1;
}

function changeS(id, color, bgcolor, weight) {
    document.getElementById(id).style.color = color;
    document.getElementById(id).style.backgroundColor = bgcolor;
    document.getElementById(id).style.fontWeight = weight;
}

function hideS(id1, id2) {
    document.getElementById(id1).style.display = 'none';
    document.getElementById(id2).style.display = 'none';
}
```
### 4. Variables and data types
#### Problem 1 - Literals
```JS
wrt('pro1', 'Problem 1. Literals' + '<br>');

var intNum = 123;
var floNum = 12.3;
var str = 'My name is';
var arr = ['jan', 'feb', 'mar', 'apr'];
var bool = true;
var car = {
    type: "Fiat",
    model: "Brava",
    make: "Italy",
    color: "red"
};
```
#### Problem 2 - Quoted text
```JS
wrt('pro2', 'Problem 2. Quoted Text' + '<br>');
var quoted = '\'What is your name?\', \'He asked\'';
wrt('pr2', quoted + '<br>');
