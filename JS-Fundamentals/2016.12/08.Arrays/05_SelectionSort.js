function solve(args) {
    let n = +args[0],
        arr = args.slice(1),
        small = Number.MIN_SAFE_INTEGER,
        sorted = [];

    for (var i = 0; i < n; i++) {
        let e = arr[i];

    }
}

// tests

solve(['6', '3', '4', '1', '5', '2', '6']);
console.log(`1
2
3
4
5
6`);
solve(['10', '36', '10', '1', '34', '28', '38', '31', '27', '30', '20']);
console.log(`1
10
20
27
28
30
31
34
36
38`);