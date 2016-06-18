// Problem 1. Exchange if greater
function solve(args) {
    var a = +args[0];
    var b = +args[1];
    var c;
    if (b < a) {
        c = a;
        a = b;
        b = c;
    }
    return a + ' ' + b;
}
// Problem 2. Multiplication Sign
function solve(args) {
    var a = +args[0];
    var b = +args[1];
    var c = +args[2];
    if ((a < 0 && b < 0 && c < 0) || (a < 0 && b > 0 && c > 0) || (a > 0 && b < 0 && c > 0) || (a > 0 && b > 0 && c < 0)) {
        return '-';
    } else if ((a > 0 && b > 0 && c > 0) || (a < 0 && b < 0 && c > 0) || (a > 0 && b < 0 && c < 0) || (a < 0 && b > 0 && c < 0)) {
        return '+';
    } else if (a === 0 || b === 0 || c === 0) {
        return '0';
    }
}
// Problem 3. The Biggest of three
function solve(args) {
    var a = +args[0];
    var b = +args[1];
    var c = +args[2];
    if (a > b) {
        if (b > c) {
            return a;
        } else {
            if (a > c) {
                return a;
            } else {
                return c;
            }
        }
    } else {
        if (b > c) {
            return b;
        } else {
            return c;
        }
    }
}
// Problem 4. Sort three numbers
function solve(args) {
    var a = +args[0];
    var b = +args[1];
    var c = +args[2];
    var out;
    if (a > b && b > c) {
        out = a + ' ' + b + ' ' + c;
    } else if (b >= a && a >= c) {
        out = b + ' ' + a + ' ' + c;
    } else if (c >= a && a >= b) {
        out = c + ' ' + a + ' ' + b;
    } else if (b >= c && c >= a) {
        out = b + ' ' + c + ' ' + a;
    } else if (c >= b && b >= a) {
        out = c + ' ' + b + ' ' + a;
    } else if (a >= c && c >= b) {
        out = a + ' ' + c + ' ' + b;
    }
    return out;
}
// Problem 5. Digit as word
function solve(args) {
    var a = +args[0];
    var out;
    switch (a) {
        case 0:
            out = 'zero';
            break;
        case 1:
            out = 'one';
            break;
        case 2:
            out = 'two';
            break;
        case 3:
            out = 'three';
            break;
        case 4:
            out = 'four';
            break;
        case 5:
            out = 'five';
            break;
        case 6:
            out = 'six';
            break;
        case 7:
            out = 'seven';
            break;
        case 8:
            out = 'eight';
            break;
        case 9:
            out = 'nine';
            break;

        default:
            out = 'not a digit';
            break;
    }
    return out;
}
// Problem 6. Quadratic equasion
function solve(args) {
    var a = +args[0];
    var b = +args[1];
    var c = +args[2];
    var d, x1, x2, elm;
    if ((isNaN(a) || isNaN(b) || isNaN(c)) || (a === 0 && b === 0 && c === 0)) {
        elm = 'no real roots';
    } else {
        if (a !== 0) {
            d = (b * b) - (4 * a * c);
            if (d < 0) {
                elm = 'no real roots';
            } else if (d === 0) {
                elm = 'x1=x2=' + ((-b) / (2 * a)).toFixed(2);
            } else if (d > 0) {
                x1 = ((-b) + (Math.sqrt(d))) / (2 * a);
                x2 = ((-b) - (Math.sqrt(d))) / (2 * a);
                if (x1 < x2) {
                    elm = 'x1=' + x1.toFixed(2) + '; x2=' + x2.toFixed(2);
                } else {
                    elm = 'x1=' + x2.toFixed(2) + '; x2=' + x1.toFixed(2);
                }
            }
        } else {
            elm = 'x1=' + ((-c) / b).toFixed(2);
        }
    }
    return elm;
}
// Problem 7. Biggest of five
function solve(args) {
    var a = +args[0];
    var b = +args[1];
    var c = +args[2];
    var d = +args[3];
    var e = +args[4];
    var elm = '';
    if (a >= b && a >= c && a >= d && a >= e) {
        elm = elm + a;
    } else if (e >= b && e >= c && e >= a && e >= d) {
        elm = elm + e;
    } else if (d >= b && d >= c && d >= e && d >= a) {
        elm = elm + d;
    } else if (c >= b && c >= d && c >= e && c >= a) {
        elm = elm + c;
    } else if (b >= c && b >= d && b >= e && b >= a) {
        elm = elm + b;
    }
    return elm;
}
// Problem 8. Numbers as words

function solve(args) {

    function capitalizeFirstLetter(string) {
        return string.charAt(0).toUpperCase() + string.slice(1);
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
                result = 'forty';
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

    var a = +args[0];
    var numAsStr = a + '';
    var text = '';
    var l = numAsStr.length - 1;
    if (a === 0) {
        return 'Zero';
    }
    for (var i = l; i >= 0; i--) {
        if (i === l) {
            text = TensNumAsWords(numAsStr.charAt(i));
        }
        if (l > 0 && i === l - 1) {
            if (numAsStr.charAt(i) == '1') {
                text = TeenNumAsWords(numAsStr.charAt(i + 1));
            } else if (numAsStr.charAt(i) == '0') {
                 continue;
            } else if(numAsStr.charAt(i + 1) == '0') { 
                text = HundNumAsWords(numAsStr.charAt(i));
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

    return capitalizeFirstLetter(text);
}