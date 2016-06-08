//Problem 1 - Exchange if greater
wrt('pro31', 'Problem 1. Exchange if greater' + '<br>');

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

//Problem 2 - Sign of product
wrt('pro32', 'Problem 2. Sign of product' + '<br>');

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

//Problem 3 - Biggest number
wrt('pro33', 'Problem 3. Biggest number' + '<br>');

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

//Problem 4 - Sort 3 numbers
wrt('pro34', 'Problem 4. Sort 3 numbers' + '<br>');

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

//Problem 5 - Digit as a word
wrt('pro35', 'Problem 5. Digit as a word' + '<br>');

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

//Problem 6 - Quadratic equasion
wrt('pro36', 'Problem 6. Quadratic equasion' + '<br>');

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

//Problem 7 - Biggest of five
wrt('pro37', 'Problem 7. Biggest of five' + '<br>');

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

//Problem 8 - Numbers in words
wrt('pro38', 'Problem 8. Numbers in words' + '<br>');

function capitalizeFirstLetter(string) {
    return string.charAt(0).toUpperCase() + string.slice(1);
}

function NumAsWords() {
    var info = document.getElementById('n38');
    var a = +info.elements[0].value;
    var numAsStr = a + '';
    var text = '';
    var l = numAsStr.length - 1;
    for (var i = l; i >= 0; i--) {
        if (i === l) {
            text = TensNumAsWords(numAsStr.charAt(i));
        }
        if (l > 0 && i === l - 1) {
            if (numAsStr.charAt(i) == '1') {
                text = TeenNumAsWords(numAsStr.charAt(i + 1));
            } else {
                text = HundNumAsWords(numAsStr.charAt(i)) + ' ' + text;
            }
        }
        if (l > 1 && i === l - 2) {
            if (numAsStr.charAt(l) === '0' && numAsStr.charAt(l - 1) === '0') {
                text = TensNumAsWords(numAsStr.charAt(i)) + ' hundred';
            } else {
                text = TensNumAsWords(numAsStr.charAt(i)) + ' hundred and ' + text;
            }
        }
    }
    text = capitalizeFirstLetter(text);
    wrt('pr38', text);
}

function TensNumAsWords(ch) {
    var result = '';
    switch (ch) {
        case '0':
            result = '';
            break;
        case '1':
            result = 'one';
            break;
        case '2':
            result = 'two';
            break;
        case '3':
            result = 'three';
            break;
        case '4':
            result = 'four';
            break;
        case '5':
            result = 'five';
            break;
        case '6':
            result = 'six';
            break;
        case '7':
            result = 'seven';
            break;
        case '8':
            result = 'eight';
            break;
        case '9':
            result = 'nine';
            break;
    }
    return result;
}

function HundNumAsWords(ch) {
    var result = '';
    switch (ch) {
        case '0':
            result = '';
            break;
        case '1':
            result = '';
            break;
        case '2':
            result = 'twenty';
            break;
        case '3':
            result = 'thirty';
            break;
        case '4':
            result = 'fourty';
            break;
        case '5':
            result = 'fifty';
            break;
        case '6':
            result = 'sixty';
            break;
        case '7':
            result = 'seventy';
            break;
        case '8':
            result = 'eighty';
            break;
        case '9':
            result = 'ninety';
            break;
    }
    return result;
}

function TeenNumAsWords(ch) {
    var result = '';
    switch (ch) {
        case '0':
            result = 'ten';
            break;
        case '1':
            result = 'eleven';
            break;
        case '2':
            result = 'twelve';
            break;
        case '3':
            result = 'thirteen';
            break;
        case '4':
            result = 'fourteen';
            break;
        case '5':
            result = 'fifteen';
            break;
        case '6':
            result = 'sixteen';
            break;
        case '7':
            result = 'seventeen';
            break;
        case '8':
            result = 'eighteen';
            break;
        case '9':
            result = 'nineteen';
            break;
    }
    return result;
}