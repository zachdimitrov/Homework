//Problem 1 - Numbers
wrt('pro41', 'Problem 1. Numbers' + '<br>');

function FromOneToN() {
    var info = document.getElementById('n41');
    var n = +info.elements[0].value;
    var result = '1';
    for (var i = 2; i <= n; i++) {
        result = result + ', ' + i;
    }
    wrt('pr41', result);
}
//Problem 2 - Numbers not divisible
wrt('pro42', 'Problem 2. Numbers not divisible' + '<br>');

function NotDivisible() {
    var info = document.getElementById('n42');
    var n = +info.elements[0].value;
    var result = '1';
    for (var i = 2; i <= n; i++) {
        if (i % 7 != 0 && i % 3 != 0) {
            result = result + ', ' + i;
        }
    }
    wrt('pr42', result);
}
//Problem 3 - Numbers not divisible
wrt('pro43', 'Problem 3. Min/Max of sequence' + '<br>');

function MaxMinValue() {
    var info = document.getElementById('n43');
    var input = info.elements[0].value;
    var n = input.split(' ');
    var max = -Number.MAX_VALUE;
    var min = Number.MAX_VALUE;
    for (var i = 0; i < n.length; i++) {
        if (+n[i] < min) {
            min = +n[i];
        }
        if (+n[i] > max) {
            max = +n[i];
        }
    }
    var text = 'Min value is: ' + min + '</br>' + 'Max value is: ' + max;
    wrt('pr43', text);
}
//Problem 4 - Properties of objects
wrt('pro44', 'Problem 4. Lexicographically smallest' + '<br>');

function GetKeys(obj) {
    var keys = [];
    for (var key in obj) {
        keys.push(key);
    }
    return keys;
}

function GetSmallest(args) {
    var sortArgs = args.sort();
    var smallest = (args[0] + '');
    return smallest;
}

function GetBiggest(args) {
    var sortArgs = args.sort();
    var biggest = (args[args.length - 1] + '');
    return biggest;
}

function WritePropertie() {
    var text = '* document * </br> Min property is: ' + GetSmallest(GetKeys(document)) + '</br>' + 'Max property is: ' + GetBiggest(GetKeys(document)) + '</br>' +
        '* window * </br> Min property is: ' + GetSmallest(GetKeys(window)) + '</br>' + 'Max property is: ' + GetBiggest(GetKeys(window)) + '</br>' +
        '* navigator * </br> Min property is: ' + GetSmallest(GetKeys(navigator)) + '</br>' + 'Max property is: ' + GetBiggest(GetKeys(navigator)) + '</br>';
    wrt('pr44', text);
}