function solve(a) {
    var n = a[0].split(' ').map(Number),
        first = +n[0],
        second = +n[1],
        third = +n[2],
        result = getMax(first, second);
    result = getMax(result, third);

    // Помощна функция
    function getMax(x, y) {
        let max = x;
        if (y > max) {
            max = y;
        }
        return max;
    }

    console.log(result);
}

// test

solve(['2 4 5 1']);