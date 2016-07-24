// 1. reverse string
function solve1(args) {
    var t = args[0],
        i, result = '';
    for (var i = t.length - 1; i >= 0; i -= 1) {
        result += t[i];
    }
    console.log(result);
}
// 2. correct brackets
function solve2(args) {
    var t = args[0],
        i, open = 0,
        closed = 0,
        result = '';
    if (t.indexOf(')') < t.indexOf('(')) {
        result = 'Incorrect'
    }
    for (var i = 0; i < t.length; i++) {
        if (t[i] === '(') {
            open += 1;
        } else if (t[i] === ')') {
            closed += 1;
        }
    }
    if (open === closed) {
        result = 'Correct';
    } else {
        result = 'Incorrect';
    }

    console.log(result);
}
// 3. substring in text
function solve(args) {
    var s = args[0].toLowerCase(),
        t = args[1].toLowerCase(),
        i, result = 0,
        x = t.Split(s);
    if (x) {
        result = 1;
        while (t.length > 0) {
        	t = t.slice(x, t.length - 1);
            x = +t.indexOf(s)
            result += 1;
        }
    }
    console.log(result);
}

solve([
    'in',
    'We are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.'
]);