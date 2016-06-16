#### Simple functions
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

function newField(id) {
    var z = document.getElementById(id);
    z.innerHTML += '<input type="number" value="0">';
}
```
### 4. Variables and data types
##### Problem 1 - Literals
```JS
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
##### Problem 2 - Quoted text
```JS
var quoted = '\'What is your name?\', \'He asked\'';
wrt('pr2', quoted + '<br>');
```
##### Problem 3 - Type of variables
```JS
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
```
##### Problem 4 - Typeof null
```JS
var nulType = null;
var nanType = NaN;
var undType;
wrt('pr4', 'Type of variable "nulType" is ' + typeof(nulType) + '<br>' +
    'Type of variable "nanType" is ' + typeof(nanType) + '<br>' +
    'Type of variable "undType" is ' + typeof(undType));
```
### 5. Operators and expressions
##### Problem 1 - odd or evens
```JS
function numInput() {
    var info = document.getElementById('n11');
    var od = '';
    var elm = '';
    var i;
    var probe;
    for (i = 0; i < info.length; i++) {

        if (info.elements[i].value % 2 === 0) {
            od = ' is Even!';
        } else {
            od = ' is Odd!';
        }
        if (info.elements[i].value != 0) {
            probe = info.elements[i].value;
            elm = elm + 'The number: ' + probe + od + '<br>';
        }
    }
    wrt('pr11', elm);
}
```
##### Problem 2 - Divide by 7 and 5
```JS
function divInput() {
    var info = document.getElementById('n12');
    var od = '';
    var elm = '';
    var i;
    var probe;
    for (i = 0; i < info.length; i++) {

        if (info.elements[i].value % 7 === 0 && info.elements[i].value % 5 === 0) {
            od = ' divides by 7 and 5 at the same time!';
        } else {
            od = ' does not divide by 7 and 5 at the same time!';
        }
        if (info.elements[i].value != 0) {
            probe = info.elements[i].value;
            elm = elm + 'The number: ' + probe + od + '<br>';
        }
    }
    wrt('pr12', elm);
}
```
##### Problem 3 - Rectangle area
```JS
function recInput() {
    var info = document.getElementById('n13');
    var x = info.elements[0].value;
    var y = info.elements[1].value;
    var area;
    area = x * y;
    elm = 'The area of the rectangle is: ' + area + ' cm2';
    wrt('pr13', elm);
}
```
##### Problem 4 - Check if third digit is 7
```JS
function sevInput() {
    var info = document.getElementById('n14');
    var does = '';
    var elm = '';
    var i;
    var probe;
    for (i = 0; i < info.length; i++) {
        var pro = ((((info.elements[i].value) / 100) - 7) | 0) % 10;
        if (pro === 0) {
            does = ' has 7 for third digit!';
        } else {
            does = ' does not meet the condition!';
        }
        if (info.elements[i].value != 0) {
            probe = info.elements[i].value;
            elm = elm + 'The number: ' + info.elements[i].value + does + '<br>';
        }
    }
    wrt('pr14', elm);
}
```
##### Problem 5 - Find the third bit
```JS
function binInput() {
    var num = document.getElementById('n15');
    var elm = '';
    var i;
    var probe;
    var bin = '';
    var th = '';

    for (i = 0; i < num.length; i++) {
        var n = num.elements[i].value;

        if (n != 0) {
            bin = (+n).toString(2);
            var mask = 1 << 3;
            var test = n & mask;
            if (test > 0) {
                th = '1';
            } else {
                th = '0';
            }
            elm = elm + 'The binary of number ' + n + ' is: ' + bin + ' and the 3-rd bit is: ' + th + '<br>';
        }
    }
    wrt('pr15', elm);
}
```
##### Problem 6 - A point in a circle
```JS
function cirInput() {
    var x = document.getElementById('x16').elements[0].value;
    var y = document.getElementById('y16').elements[0].value;
    var k = document.getElementById('k16').elements[0].value;
    var elm = '';
    var i;
    var rsqu = k * k;
    var result = x * x + y * y;
    var test = '';

    //for (i = 0; i < num.length; i++) {
    if (rsqu >= result) {
        test = ' is within a circle with radius ' + k;
    } else {
        test = ' is outside a circle with radius ' + k;
    }
    elm = 'The point with coordinates: ' + x + ' and ' + y + test + '<br>' +
        'r2 =  ' + rsqu + '<br>' + 'x2+y2 = ' + result;
    //}
    wrt('pr16', elm);
```
##### Problem 7 - Check if number is prime
```JS
function prmInput() {
    var info = document.getElementById('n17');
    var does = '';
    var elm = '';
    var i;
    for (i = 0; i < info.length; i++) {
        var pro = +info.elements[i].value;
        var j;
        var test = false;
        for (j = 2; j <= Math.sqrt(pro); j = j + 1) {
            if (pro % j === 0) {
                test = true;
            }
        }
        if (test) {
            elm = elm + 'The number ' + pro + ' is not prime.' + '<br>';
        } else {
            elm = elm + 'The number ' + pro + ' is prime!!!' + '<br>';
        }
    }
    wrt('pr17', elm);
}
```
##### Problem 8 - Trapezoid area
```JS
function traInput() {
    var info = document.getElementById('n18');
    var a = +info.elements[0].value;
    var b = +info.elements[1].value;
    var h = +info.elements[2].value;
    var area;
    area = (a + b) * (h / 2);
    elm = 'The area of the trapezoid is: ' + area + ' cm2';
    wrt('pr18', elm);
}
```
### 6. Conditional statements
##### Problem 1 - Exchange if greater
```JS
function eigInput() {
    var info = document.getElementById('n31');
    var a = +info.elements[0].value;
    var b = +info.elements[1].value;
    var test = '';
    test = a + ', ' + b;
    if (+a < +b) {
        test = b + ', ' + a;
    }
    elm = 'The order of numbers is: ' + test;
    wrt('pr31', elm);
}
```
##### Problem 2 - Sign of product
```JS
function sopInput() {
    var info = document.getElementById('n32');
    var a = +info.elements[0].value;
    var b = +info.elements[1].value;
    var c = +info.elements[2].value;
    var test = '+';
    if (a === 0 || b === 0 || c === 0) {
        test = '0';
    } else if ((a < 0 && b > 0 && c > 0) ||
        (a > 0 && b < 0 && c > 0) ||
        (a > 0 && b > 0 && c < 0) ||
        (a < 0 && b < 0 && c < 0)) {
        test = '-';
    } else if ((a < 0 && b < 0 && c > 0) ||
        (a < 0 && b > 0 && c < 0) ||
        (a > 0 && b < 0 && c < 0)) {
        test = '+';
    }
    elm = 'The sign of product is: ' + test;
    wrt('pr32', elm);
}
```
##### Problem 3 - Biggest number
```JS
function bigFind() {
    var info = document.getElementById('n33');
    var a = +info.elements[0].value;
    var b = +info.elements[1].value;
    var c = +info.elements[2].value;
    var test = c;
    if (a > b && a > c) {
        test = a;
    } else if (b > a && b > c) {
        test = b;
    }
    elm = 'The biggest number is: ' + test;
    wrt('pr33', elm);
}
```
##### Problem 4 - Sort 3 numbers
```JS
function sortNum() {
    var info = document.getElementById('n34');
    var a = +info.elements[0].value;
    var b = +info.elements[1].value;
    var c = +info.elements[2].value;
    var test = a + ', ' + b + ', ' + c;
    if (b > a && a > c) {
        test = b + ', ' + a + ', ' + c;
    } else if (b > c && c > a) {
        test = b + ', ' + c + ', ' + a;
    } else if (c > a && a > b) {
        test = c + ', ' + a + ', ' + b;
    } else if (c > b && b > a) {
        test = c + ', ' + b + ', ' + a;
    }
    elm = 'The order of numbers is: ' + test;
    wrt('pr34', elm);
}
```
##### Problem 5 - Digit as a word
```JS
function digWord() {
    var info = document.getElementById('n35');
    var a = +info.elements[0].value;
    var test = '';
    switch (a) {
        case 0:
            test = 'Zero';
            break;
        case 1:
            test = 'One';
            break;
        case 2:
            test = 'Two';
            break;
        case 3:
            test = 'Three';
            break;
        case 4:
            test = 'Four';
            break;
        case 5:
            test = 'Five';
            break;
        case 6:
            test = 'Six';
            break;
        case 7:
            test = 'Seven';
            break;
        case 8:
            test = 'Eight';
            break;
        case 9:
            test = 'Nine';
            break;
        default:
            test = 'Not a digit!';
    }
    elm = 'The entered digit is: ' + test;
    wrt('pr35', elm);
}
```
##### Problem 6 - Quadratic equasion
```JS
function quadratic() {
    var info = document.getElementById('n36');
    var a = +info.elements[0].value;
    var b = +info.elements[1].value;
    var c = +info.elements[2].value;
    var d;
    var elm = '';
    if ((isNaN(a) || isNaN(b) || isNaN(c)) || (a === 0 && b === 0 && c === 0)) {
        elm = 'Please enter coefficients!';
    } else {
        if (a !== 0) {
            d = (b * b) - (4 * a * c);
            if (d < 0) {
                elm = 'The equasion has no real roots!';
            } else if (d === 0) {
                elm = 'The equasion has one root X=' + (-b) / (2 * a);
            } else if (d > 0) {
                elm = 'The equasion has two roots: X1=' +
                    ((-b) + (Math.sqrt(d))) / (2 * a) + ', X2=' + ((-b) - (Math.sqrt(d))) / (2 * a);
            }
        } else {
            elm = 'The equasion is linary and has one root X=' + (-c) / b;
        }
    }
    wrt('pr36', elm);
}
```
##### Problem 7 - Biggest of five
```JS
function bigFive() {
    var info = document.getElementById('n37');
    var a = +info.elements[0].value;
    var b = +info.elements[1].value;
    var c = +info.elements[2].value;
    var d = +info.elements[3].value;
    var e = +info.elements[4].value;
    var elm = 'The biggest number is: ';
    if (a > b && a > c && a > d && a > e) {
        elm = elm + a;
    } else if (e > b && e > c && e > a && e > d) {
        elm = elm + e;
    } else if (d > b && d > c && d > e && d > a) {
        elm = elm + d;
    } else if (c > b && c > d && c > e && c > a) {
        elm = elm + c;
    } else if (b > c && b > d && b > e && b > a) {
        elm = elm + b;
    }
    wrt('pr37', elm);
}
```
##### Problem 8 - Numbers in words
