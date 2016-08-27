console.log("------------------- example 1");
// print arguments

function myFunc() {
    console.log(arguments); // will print the arguments object
}
myFunc("zahari", true, 34);

console.log("------------------- example 2");
// max number of array

function max(arr) {
    if (Array.isArray(arr)) {
        var max = arr[0];
        arr.forEach(n => max = Math.max(n, max));
        return max;
    } else {
        console.log("Ne si podal masiv!")
    }
}

console.log(max([2, 45, 1, 232, 772, 22]));
console.log(["edno", "dve", "tri"]);
console.log("------------------- example 3");
// sum of items

function sum(...items) {
    if (Array.isArray(items[0])) {
        items = items[0];
    }

    let itemsSum = 0;
    if (typeof items[0] !== "number") {
        itemsSum = "";
    }

    for (let item of items) {
        itemsSum += item;
    }

    return itemsSum;
}

console.log(sum(4, 5, 6));
console.log(sum([20, 345, 87], [22983, 221], 8));
console.log(sum("pesho", " ", "ivanov"));
console.log("------------------- example 4");
// function properties
var properties =
    sum.length + "\n" +
    sum.name + "\n" +
    sum.prototype + "\n" +
    sum.caller;

console.log(properties);
console.log("------------------- example 5");
// function evaluate
(function() { /* ... */ });
var printMsg = (msg) => console.log(`Message: ${msg}`);
printMsg("hello");

console.log("------------------- example 6");
// function constructor
var func = new Function("age", "console.log(age)");
func(22);

console.log("------------------- example 7");
// function methods
var methods =
    sum.toString() + "\n" +
    sum.call(null, 3, 6, 7, 8) + "\n" +
    sum.apply(null, [5, 65, 22]);
// vmesto null moje da se podade drug context
console.log(methods);

function sumNew() {
    var args = [].slice.call(arguments);
    return args.reduce((s, n) => s + n, 0);
}
console.log(sumNew(1, 5, 6, 3, 23));
console.log("------------------- example 8");
// function recursion

function fact(f) {
    if (f === 0) {
        return 1;
    }
    return fact(f - 1) * f;
}

console.log(fact(12));

console.log("------------------- example 9");
// DOM recursion
function traverse(element) {
    function travElem(node, spacing) {
        if (node.nodeType !== 1) {
            return;
        }

        spacing = spacing || " ";

        console.log(spacing + node.nodeName);
        [...node.childNodes].forEach(child => travElem(child, spacing + "--"));
        console.log(spacing + "/" + node.nodeName);
    }
    travElem(element, "");
}

traverse(document.childNodes[1]);

console.log("------------------- example 10");
// nested functions

function outer() {
    var num1 = 5;
    console.log(num1);
    return function middle() {
        var num2 = 30;
        console.log(num2 + num1);
        return function inner() {
            return console.log('Makes sence?');
        }
    }
}

var func = outer;
func = func();
func = func();
func = func();

console.log("------------------- example 11");
// Immediately-Invoked Function Expression (IIFE)

(function iife1() {
    console.log("iife1");
})(); // option 1

(function iife2() {
    console.log("iife2");
}()); // option 2 - best option

var iife3 = function() {
    console.log("iife3")
}(); // option 3

! function() {
    console.log("iife4")
}(); // option 4

true && function() {
    console.log("iife5")
}(); // option 5

1 + function() {
    console.log("iife6")
}(); // option 6

console.log("------------------- example 12");
// Immediately-Invoked Function Expression (IIFE)

var getNextId = (function() {
    var lastId = 0;
    return function() {
        return lastId += 1;
    }
})();

console.log(getNextId());
console.log(getNextId());
console.log(getNextId());
console.log(getNextId());

console.log("------------------- example 13");
// module

var generator = (function() {
    var lastId = 0;

    function getCurrentId() {
        return lastId;
    }

    function getNextId() {
        return lastId += 1;
    }

    return {
        curr: getCurrentId,
        next: getNextId
    }
})();

console.log(generator.next());
console.log(generator.curr());
console.log(generator.next());
console.log(generator.curr());