// problem 1. odd or even
function solve(args) {
    var input = +args[0];
    var od = '';
    if (input % 2 === 0) {
        od = 'even';
    } else {
        od = 'odd';
    }
    return od + ' ' + input;
}

// problem 2. divide by 7 and 5
function solve(args) {
    var input = +args[0];
    var od = '';
    if (input % 7 === 0 && input % 5 === 0) {
        od = 'true';
    } else {
        od = 'false';
    }
    return od + ' ' + input;
}

// problem 3. rectangles
function solve(args) {
    var a = +args[0];
    var b = +args[1];
    var area = a * b;
    var perm = 2 * a + 2 * b;
    return area.toFixed(2) + ' ' + perm.toFixed(2);
}

// problem 4. third digit
function solve(args) {
    var input = +args[0];
    var digit;

    digit = Math.floor(input / 100) % 10;
    if (digit === 7) {
        return 'true';
    } else {
        return 'false' + ' ' + digit;
    }
}

// problem 5. third bit
function solve(args) {
    var n = +args[0];
    var bin, mask, test;

    bin = (n).toString(2);
    mask = 1 << 3;
    test = n & mask;
    if (test > 0) {
        return '1';
    } else {
        return '0';
    }
}

// problem 6. point in a circle
function solve(args) {
    var x = +args[0];
    var y = +args[1];
    var k = 2;
    var result = x * x + y * y;
    var distance = Math.sqrt(result);

    if (k >= distance) {
        return 'yes ' + distance.toFixed(2);
    } else {
        return 'no ' + distance.toFixed(2);
    }
}

// problem 7. prime check
function solve(args) {
    var pro = +args[0];
    var j;
    var isPrime = true;

    if (pro <= 1) {
        return 'false';
    } else if (pro <= 3) {
        return 'true';
    } else {
        for (j = 2; j <= Math.sqrt(pro); j = j + 1) {
            if (!(pro % j)) {
                isPrime = false;
            }
        }
        if (isPrime) {
            return 'true';
        } else {
            return 'false';
        }
    }
}

// problem 8. trapezoid area
function solve(args) {

}