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

function wrt(iid, txt) {
    var x = document.getElementById(iid);
    x.innerHTML = txt;
}

//Problem 1 - Literals
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

//Problem 2 - Quoted text
wrt('pro2', 'Problem 2. Quoted Text' + '<br>');
var quoted = '\'What is your name?\', \'He asked\'';
wrt('pr2', quoted + '<br>');

//Problem 3 - Type of variables
wrt('pro3', 'Problem 3. Type of Variables' + '<br>');

function getName(what) {
    for (var name in window) {
        if (window[name] == what)
            return (name);
    }
    return ("");
}

function prType(x) {
    var str = 'type of "' + getName(x) + '" is: ' +
        typeof(x) + '<br>';
    return str;
}

var y = document.getElementById('pr3');
y.innerHTML =
    prType(intNum) +
    prType(floNum) +
    prType(str) +
    prType(arr) +
    prType(bool) +
    prType(car);


//Problem 4 - Typeof null
wrt('pro4', 'Problem 4. Type of Variables' + '<br>');
var nulType = null;
var nanType = NaN;
var undType;
wrt('pr4', 'Type of variable "nulType" is ' + typeof(nulType) + '<br>' +
    'Type of variable "nanType" is ' + typeof(nanType) + '<br>' +
    'Type of variable "undType" is ' + typeof(undType));