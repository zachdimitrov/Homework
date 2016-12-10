function solve(args) {
    let number = +args[0],
        result;

    if (!(number % 5) && !(number % 7)) {
        result = "true";
    } else {
        result = "false";
    }
    console.log(`${result} ${number}`);
}