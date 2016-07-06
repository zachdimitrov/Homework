// 01. Planar coordinates
function solve(n) {
    var x1 = +n[0],
        y1 = +n[1],
        x2 = +n[2],
        y2 = +n[3],
        x3 = +n[4],
        y3 = +n[5],
        x4 = +n[6],
        y4 = +n[7],
        x5 = +n[8],
        y5 = +n[9],
        x6 = +n[10],
        y6 = +n[11],
        line1 = 0,
        line2 = 0,
        line3 = 0,
        can;

    line1 = Math.sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
    line2 = Math.sqrt((x4 - x3) * (x4 - x3) + (y4 - y3) * (y4 - y3));
    line3 = Math.sqrt((x6 - x5) * (x6 - x5) + (y6 - y5) * (y6 - y5));

    if (line1 + line2 > line3 && line1 + line3 > line2 && line2 + line3 > line1) {
        can = 'Triangle can be built';
    } else {
        can = 'Triangle can not be built';
    }

    console.log(line1.toFixed(2));
    console.log(line2.toFixed(2));
    console.log(line3.toFixed(2));
    console.log(can);
}

solve(['5', '6', '7', '8', '1', '2', '3', '4', '9', '10', '11', '12']);

// 02. Remove elements
function solve(n) {
    var rem = n[0],
        arr = [];
    n.shift();
    for (var i = 0; i < n.length; i++) {
        if (n[i] != rem) {
            arr.push(n[i]);
        }
    }
    for (var j = 0; j < arr.length; j++) {
        console.log(arr[j]);
    }
}

solve(['5', '6', '7', '5', '1', '5', '3', '4', '9', '5', '11', '12']);
// 05. Youngest person

function solve(args) {
    var people = [],
        step = 3,
        input = args,
        i;

    for (i = 0; i < input.length; i += step) {
        people.push({
            firstName: input[i] + '',
            lastName: input[i + 1] + '',
            age: +input[i + 2]
        });
    }

    var youngest = people.reduce(
        function(a, b) {
            return a.age <= b.age ? a : b;
        });

    console.log(youngest.firstName + ' ' + youngest.lastName);
}

solve([
    'Penka', 'Hristova', '61',
    'System', 'Failiure', '88',
    'Bat', 'Man', '16',
    'Malko', 'Kote', '72'
]);