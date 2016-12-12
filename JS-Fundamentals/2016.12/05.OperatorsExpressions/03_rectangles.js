function solve(args) {
    let width = +args[0],
    height = +args[1], 
    area = width * height, 
    perimeter = 2*(width+height);

    console.log(`${area} ${perimeter}`);
}