var stage = new Kinetic.Stage({
    container: 'kin-container',
    width: 1000,
    height: 500
});

var layer = new Kinetic.Layer();
var bgLayer = new Kinetic.Layer();

var rect = new Kinetic.Rect({
    x: 100,
    y: 400,
    width: 75,
    height: 50,
    fill: 'yellowgreen',
    stroke: 'purple',
    lineWidth: 5,
    draggable: true
});

var circle = new Kinetic.Circle({
    x: 400,
    y: 250,
    radius: 45,
    fill: 'purple',
    stroke: 'blue',
    strokeWidth: 3,
    draggable: true
})

shape = new Kinetic.Line({
    points: [50, 300, 100, 300, 200, 350, 100, 400, 50, 400, 100, 350],
    stroke: 'purple',
    fill: 'red',
    closed: true,
    tension: 0.2,
    draggable: true
});
shape.color1 = 'red';
shape.color2 = 'blue';

shape2 = new Kinetic.Line({
    points: [150, 300, 200, 300, 250, 350, 200, 400, 150, 400],
    stroke: 'purple',
    fill: 'red',
    closed: true,
    tension: -0.5,
    draggable: true
});
shape2.color1 = 'black';
shape2.color2 = 'yellow';

layer.add(shape);
layer.add(shape2);

shape.rotate(5);

layer.find('Line').forEach(function(sh) {
    sh.on('mouseenter', function() {

        if (sh.fill() === sh.color1) {
            sh.fill(sh.color2);
        } else {
            sh.fill(sh.color1);
        }
        layer.draw();
    });
});
var delta = 5;

function animFrame() {
    rect.setX(rect.getX() + delta);
    if (rect.getX() > 1000 - rect.width() || rect.getX() < 0) {
        delta *= -1;
    }
    layer.draw();
    requestAnimationFrame(animFrame);
}

animFrame();

var move = 5;

function animation() {
    circle.setX(circle.getX() + move);
    if (circle.getX() > 1000 - circle.getGadius() || circle.getX() < 0) {
        move *= -1;
    }
    layer.draw();

    setTimeout(animation, 10);
}

//animation();

var points = [];
for (var i = 0; i <= stage.getWidth(); i += 5) {
    var x = i - Math.floor(Math.random() * 5);
    var y = ((i / 5) % 2) ? 480 : 500;
    points.push(x);
    points.push(y);
}

grass = new Kinetic.Line({
    points: points,
    stroke: 'green',
    fill: 'lightgreen',
    closed: true
});

bgLayer.add(grass);
layer.add(circle);
layer.add(rect);

stage.add(bgLayer);
stage.add(layer);