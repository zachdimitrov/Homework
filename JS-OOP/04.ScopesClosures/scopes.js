// "use strict";
// ------ example 1 -------
if (true) {
    var number = 42;
}
console.log(number);

function arrJoin(array, separator) {
    array = array || [];
    separator = separator || "";
    var arrString = "";
    for (var i = 0; i < array.length; i += 1) {
        arrString += array[i];
        if (i < array.length - 1) {
            arrString += separator;
        }
    }
    console.log(arrString);
};

var arrtojoin = ["7", "9", "66", "re", "ik"]
arrJoin(arrtojoin, "|");

function assign(n) {
    n = 42;
    return n;
}

var number = 17;
console.log(assign(number));
console.log(number);

// -------- web example --------
var items = document.getElementsByClassName('item');
console.log(items);

for (var index = 0; index < items.length; index += 1) {
    (function() {
        var i = index + 1;
        items[index].addEventListener('click', function() {
            alert(`Item ${i} was clicked!!!`);
        });
    })();
}
// ------- closure example -------
function outer(x) {
    function inner(y) {
        return x + " " + y;
    }
    return inner;
}
// ------- let example --------
console.log(outer(5)(8));

if (true) {
    let y = 777;
    const z = 221;
    if (true) {
        console.log(y + " " + z);
    }
}
// ------- encapsulation example --------
function counter() {
    let count = 0;

    function increase() {
        count += 1;
        return count;
    }

    function decrease() {
        count -= 1;
        return count;
    }
    return {
        inc: increase,
        dec: decrease
    };
}

let call = counter();

console.log(call.inc());
console.log(call.inc());
console.log(call.dec());
console.log(call.inc());
console.log(call.dec());
console.log(call.inc());
