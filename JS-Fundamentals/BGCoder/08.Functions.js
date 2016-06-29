// problem 1. Say Hello
function solve(args) {
    var name = args[0];

    function sayHello(n) {
        return 'Hello, ' + n + '!';
    }
    return sayHello(name);
}
// problem 2. Get largest number
function solve(args) {

    var numbers = args[0].split(' ');

    return compare(+numbers[0], compare(+numbers[1], +numbers[2]));

    function compare(a, b) {
        if (a > b) {
            return a;
        } else if (b > a) {
            return b;
        } else {
            return a;
        }
    }
}
// problem 3. English digit
function solve(args) {
    var num = String(args),
        digit = num[num.length - 1];

    switch (digit) {
        case '0':
            return 'zero';
        case '1':
            return 'one';
        case '2':
            return 'two';
        case '3':
            return 'three';
        case '4':
            return 'four';
        case '5':
            return 'five';
        case '6':
            return 'six';
        case '7':
            return 'seven';
        case '8':
            return 'eight';
        case '9':
            return 'nine';
    }
}
// Problem 4. Appearance count
function solve(args) {
    var searchedNumber = +args[2],
        numbers = args[1].split(' ').map(Number);

    return countTimes(numbers, searchedNumber);

    function countTimes(numArray, numberToSearch) {
        var i, len, count = 0;

        for (i = 0, len = numArray.length; i < len; i += 1) {
            if (numArray[i] === numberToSearch) {
                count += 1;
            }
        }
        return count;
    }
}
// problem 5. Larger than neighbours
function solve(args) {
    var numbers = args[1].split(' ').map(Number);

    return findNeighbours(numbers);

    function findNeighbours(numArray) {
        var i, len,
            currNum, before, after,
            count = 0;

        for (i = 1, len = numArray.length; i < len - 1; i += 1) {
            before = numArray[i - 1];
            currNum = numArray[i];
            after = numArray[i + 1];

            if (currNum > before && currNum > after) {
                count += 1;
            }
        }
        return count;
    }
}
// problem 6. Larger than neighbours
function solve(args) {

    var numbers = args[1].split(' ').map(Number);

    return findIndex(numbers);

    function findIndex(numArray) {
        var i, len, index;
        for (i = 1, len = numArray.length; i < len - 1; i += 1) {
            if (numArray[i] > numArray[i - 1] && numArray[i] > numArray[i + 1]) {
                index = i;
                break;
            }
        }
        return index;
    }
}
// problem 7. Sorting Array
function solve(args) {
    var len = +args[0],
        numbers = args[1].split(' ').map(Number);

    return sortByDescendingOrder(numbers).reverse().join(' ');

    function sortByDescendingOrder(array) {
        var i, len, maxEl, maxElIndex, temp;

        for (i = 0, len = array.length; i < len; i += 1) {
            maxEl = getMax(i, array);
            maxElIndex = array.indexOf(maxEl, i);
            temp = array[i];
            array[i] = maxEl;
            array[maxElIndex] = temp;
        }
        return array;
    }

    function getMax(index, numArray) {
        var i, len,
            maxElement = Number.NEGATIVE_INFINITY;

        for (i = index, len = numArray.length; i < len; i += 1) {
            if (numArray[i] > maxElement) {
                maxElement = numArray[i];
            }
        }
        return maxElement;
    }
}