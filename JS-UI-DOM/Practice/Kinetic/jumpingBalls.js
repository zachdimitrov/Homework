var stage = new Kinetic.Stage({
    container: 'kin-container',
    width: 1000,
    height: 500
});

var layer = new Kinetic.Layer();

var i, count = 10;

for (var i = 0; i < count; i += 1) {
    var ball = new Kinetic.Circle({
        x: Math.random() * (stage.getWidth() - 30),
        y: Math.random() * (stage.getHeight() - 30),
        radius: 15,
        fill: 'purple',
        stroke: 'blue',
        strokeWidth: 3
    });
    ball.movex = 5;
    ball.movey = 5;

    layer.add(ball);
}

// var circle = new Kinetic.Circle({
//     x: 15,
//     y: 15,
//     radius: 15,
//     fill: 'purple',
//     stroke: 'blue',
//     strokeWidth: 3,
//     draggable: true
// });

function animation() {
    var balls = layer.find('Circle');

    balls.forEach(function(circle) {
        var x = circle.getX() + circle.movex,
            y = circle.getY() + circle.movey,
            r = circle.getRadius();

        if (x - r < 0 || x + r > stage.getWidth()) {
            circle.movex *= -1;
        }

        if (y - r < 0 || y + r > stage.getHeight()) {
            circle.movey *= -1;
        }

        if (balls.some(function(other) {
                if (other === circle) {
                    return false;
                }
                var b1 = {
                        x: circle.getX(),
                        y: circle.getY(),
                        r: circle.getRadius()
                    },
                    b2 = {
                        x: other.getX(),
                        y: other.getY(),
                        r: other.getRadius()
                    };
                var d = Math.sqrt((b1.x - b2.x) * (b1.x - b2.x) +
                    (b1.y - b2.y) * (b1.y - b2.y));
                return d <= (b1.r + b2.r);
            })) {
            circle.movex *= -1;
            circle.movey *= -1;
        }

        circle.setX(circle.getX() + circle.movex);
        circle.setY(circle.getY() + circle.movey);
    });

    layer.draw();

    setTimeout(animation, 10);
}

animation();

// layer.add(circle);
stage.add(layer);