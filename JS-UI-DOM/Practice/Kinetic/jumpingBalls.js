var stage = new Kinetic.Stage({
    container: 'kin-container',
    width: 1000,
    height: 500
});

var layer = new Kinetic.Layer();

var i, count = 15;

for (var i = 0; i < count; i += 1) {
    var ball = new Kinetic.Circle({
        x: Math.random() * (stage.getWidth() - 30),
        y: Math.random() * (stage.getHeight() - 30),
        radius: 15,
        fill: 'purple',
        stroke: 'blue',
        strokeWidth: 3
    });

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

var updatex = Array.apply(null, { length: count })
    .map(function() {
        return Math.random() * 5;
    })
var updatey = Array.apply(null, { length: count })
    .map(function() {
        return Math.random() * 5;
    });

function animation() {
    var balls = layer.find('Circle');
    balls.forEach(function(circle, index) {
        var movex = updatex[index];
        var movey = updatey[index];

        circle.setX(circle.getX() + movex);
        if (circle.getX() > stage.getWidth() - circle.getRadius() || circle.getX() < circle.getRadius()) {
            movex *= -1;
        }

        circle.setY(circle.getY() + movey);
        if (circle.getY() > stage.getHeight() - circle.getRadius() || circle.getY() < circle.getRadius()) {
            movey *= -1;
        }

        if (balls.some(function(other) {
                if (other === ball) {
                    return false;
                }
                var b1 = {
                        x: ball.getX(),
                        y: ball.getY(),
                        r: ball.getRadius()
                    },
                    b2 = {
                        x: other.getX(),
                        y: other.getY(),
                        r: other.getRadius()
                    },
                    d = Math.sqrt((b1.x - b2.x) * (b1.x - b2.x) +
                        (b1.y - b2.y) + (b1.y - b2.y));
                return d <= (b1.r + b2.r);
            })) {
            movex *= -1;
            movey *= -1;
        }
circle.setX(circle.getX() + movex);
circle.setY(circle.getY() + movey);
        updatex[index] = movex;
        updatey[index] = movey;
    });

    layer.draw();

    setTimeout(animation, 10);
}

animation();

// layer.add(circle);
stage.add(layer);