// problem 1. Increase array members
function solve(args) {
    var n = +args[0],
        arr, i;
    arr = new Array(n);
    for (i = 0; i < arr.length; i++) {
        arr[i] = +(5 * i);
        console.log(arr[i]);
    }
}
// problem 2. Lexicographically comparison
function solve(args) {
    var arr = args[0].split('\n')
    var text1 = String(arr[0]);
    var text2 = String(arr[1]);
    var result = '=';

    if (text1 > text2) {
        result = '>';
    } else if(text1 < text2) {
        result = '<';
    }
    return result;
}
// problem 3. Maximal Sequence
function solve(args) {
    var arr = args[0].split('\n'),
        n = +arr[0],
        numbers = arr.slice(1),
        test = +numbers[0],
        sum = 1,
        max = 0;

    for (var i = 0; i < n; i += 1) {

        if (test === +numbers[i + 1]) {
            sum++;
        }
        else {
            if (sum > max) {
                max = sum;
            }
            sum = 1;
        }
        test = +numbers[i + 1];
    }
    return max;
}
// problem 4. Maximal Increasing Sequence
function solve(args) {
    var arr = args[0].split('\n'),
        n = +arr[0],
        numbers = arr.slice(1),
        test = +numbers[0],
        sum = 1,
        max = 0;

    for (var i = 0; i < n; i += 1) {

        if (test < +numbers[i + 1]) {
            sum++;
        }
        else {
            if (sum > max) {
                max = sum;
            }
            sum = 1;
        }
        test = +numbers[i + 1];
    }
    return max;
}
// problem 5. Selection Sort
function solve(args) {
    var arr = args[0].split('\n'),
        n = +arr[0],
        numbers = arr.slice(1),
        min;

        for (var i = 0; i < n; i = i + 1) {
            min = numbers[i]
            for (var j = i; j < n; j = j + 1) {
                if (+numbers[j] < min) {
                    min = +numbers[j];
                    numbers[j] = +numbers[i];
                    numbers[i] = min;
                }
            }
        }
        return numbers.join('\n');
}
// problem 6. Most frequent numbers
function solve(args) {
    var arr = args[0].split('\n'),
        n = +arr[0],
        numbers = arr.slice(1),
        test = numbers[0],
        count = 1,
        biggest = 0,
        bestCount = 0;

        numbers.sort();

        for (var i = 0; i < n; i++) {
            if (test === numbers[i + 1]) {
                count++;
            } else {
                if (count > bestCount) {
                    bestCount = count;
                    biggest = numbers[i];
                }
                count = 1;
            }
            test = numbers[i + 1];
        }
    return biggest + ' (' + bestCount + ' times)';
}
// problem 7. Binary search
function solve(args) {
var arr = (args + '').split('\n').map(Number),
        n = +arr[0],
        x = +arr[arr.length - 1],
        min = 0,
        max = n - 1,
        mid = 0;

        arr.shift();
        arr.pop();
        while (min <= max) {
            mid = ((min + max) / 2) | 0;
            if (x === +arr[mid]) {
                return mid;
            } else if(x < +arr[mid]) {
                max = mid - 1;
            } else {
                min = mid + 1;
            }
        }
    return '-1';
}
// problem 8. Prime Numbers
function solve(args) {

    var number = +args[0],
        isPrime;

    for (var i = number; i >= 2; i -= 1) {
        isPrime = true;
        for (var j = 2; j <= Math.sqrt(number); j += 1) {
            if (i % j === 0) {
                isPrime = false;
                break;
            }
        }
        if (isPrime === true) {
            return i;
        }
    }
    return '-1';
}