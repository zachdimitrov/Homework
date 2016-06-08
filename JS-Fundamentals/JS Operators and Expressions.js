//Problem 1 - odd or Evens
wrt('pro11', 'Problem 1. Odd or Even' + '<br>');

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

//Problem 2 - Divide by 7 and 5
wrt('pro12', 'Problem 2. Divide by 7 and 5' + '<br>');

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

//Problem 3 - Rectangle area
wrt('pro13', 'Problem 3. Find rectangle area' + '<br>');

function recInput() {
    var info = document.getElementById('n13');
    var x = info.elements[0].value;
    var y = info.elements[1].value;
    var area;
    area = x * y;
    elm = 'The area of the rectangle is: ' + area + ' cm2';
    wrt('pr13', elm);
}

//Problem 4 - Check if third digit is 7
wrt('pro14', 'Problem 4. Check if third digit is 7' + '<br>');

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

//Problem 5 - Find the third bit
wrt('pro15', 'Problem 5. Find the third bit' + '<br>');

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

//Problem 6 - A point in a circle
wrt('pro16', 'Problem 6. A Point in a circle' + '<br>');

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
}

//Problem 7 - Check if number is prime
wrt('pro17', 'Problem 7. Check if number is prime' + '<br>');

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

//Problem 8 - Trapezoid area
wrt('pro18', 'Problem 8. Trapezoid area' + '<br>');

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
//Problem 9 - Point in Circle and outside Rectangle
wrt('pro19', 'Problem 9. Point in Circle and outside Rectangle' + '<br>');

function pointInCirOutsideRect() {
    var info = document.getElementById('n19');
    var x = +info.elements[0].value;
    var y = +info.elements[1].value;
    var message = '';
    // radius squared = 9
    var test = ((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 9 && (x < -1 || (y > 1 || y < -1));
    if (test) {
        message = ' is within a circle ((1,1), 3) and outside rectangle (-1,-1, h2, w6)'
    } else {
        message = ' does not meet the condition!'
    }
    message = 'The point with coordinates: ' + x + ' and ' + y + message;
    wrt('pr19', message)
}