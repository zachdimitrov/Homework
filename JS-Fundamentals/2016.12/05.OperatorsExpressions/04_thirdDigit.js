function solve(args) {
    let number = +args[0],
        digit = ((number / 100) | 0) % 10;

    if (!(digit % 7)) {
        console.log(`true`);
    } else {
        console.log(`false ${digit}`);
    }
}