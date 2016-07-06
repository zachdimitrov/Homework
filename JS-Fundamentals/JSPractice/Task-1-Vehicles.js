function solve(args) {
    var s = +args[0];
    var i,
        j,
        k,
        count = 0;
    //10
    for (var i = 0; i <= s / 10; i += 1) {
        //4
        for (var j = 0; j <= s / 4; j += 1) {
            //3
            for (var k = 0; k <= s / 3; k += 1) {
                //7
                if (i * 10 + j * 4 + k * 3 == s) {
                    count += 1;
                }
            }
        }
    }
    console.log(count);
}

console.log(solve(['40']));