function solve(args) {
    let mask = 1 << 3, // turn on 3-rd bit of mask
        bit = +args[0] & mask, // delete all but third bit of number
        result = bit >> 3; // shift result to 0 position

    console.log(result);
}