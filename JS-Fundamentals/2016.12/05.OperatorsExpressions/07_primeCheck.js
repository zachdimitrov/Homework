function solve(args) {
    let number = +args[0],
        i,
        result = "true";

    if (number < 2) {
        result = false;
    }

    for (i = 2; i < number / 2; i += 1) {
        if (!(number % i)) {
            result = "false";
        }
    }

    console.log(result);
}