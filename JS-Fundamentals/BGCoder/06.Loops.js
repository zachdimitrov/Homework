// Problem 1. Numbers from 1 to N
function solve(args) {
    var n = +args[0];
    var result, i;
    for (i = 1; i <= n; i = i + 1) {
        result = result + ' ' + i;
    }
    return result;
}
// Problem 2. MMSA
//var args = [1.56, 2.3445, 3.67, 4, 5, 6, 7];

function solve(args) {
    var min = +args[0];
    var max = +args[0];
    var e;
    var sum = 0;
    var avg = 0;
    var i = 0;

    for (i = 0; i < args.length; i = i + 1) {
        e = +args[i];
        if (e <= min) { min = e; }
        if (e >= max) { max = e; }
        sum = sum + e;
    }
    avg = (sum / args.length).toFixed(2)
    return 'min=' + min.toFixed(2) + '\n' +
        'max=' + max.toFixed(2) + '\n' +
        'sum=' + sum.toFixed(2) + '\n' +
        'avg=' + avg;
}
// Problem 3. Matrix of Numbers
function solve(args) {
    var n = +args[0];
    var result = '',
        i;
    for (i = 1; i <= n; i = i + 1) {
        for (var j = i; j < n + i; j = j + 1) {
            result = result + j + ' ';
        }

        result = result + '\n';
    }
    return result;
}
// Problem 4. Hex to Decimal
function solve(args) {
    var hex = args[0], dec = 0, pol = 1, ch = 0;

    for (var i = hex.length - 1; i >= 0; i = i - 1) {
    	switch (hex[i]) {
    		case 'A': ch = 10; break;
    		case 'B': ch = 11; break;
    		case 'C': ch = 12; break;
    		case 'D': ch = 13; break;
    		case 'E': ch = 14; break;
    		case 'F': ch = 15; break;
    		default: ch = +hex[i];
    	}

    	dec = dec + ch * pol;
        pol = pol * 16;
    }
    return dec;
}
