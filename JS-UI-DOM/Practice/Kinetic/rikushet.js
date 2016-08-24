var stage = new Kinetic.Stage({
    container: 'kin-container',
    width: 1000,
    height: 500
});

var layer = new Kinetic.Layer();

var player = new Kinetic.Circle({
    radius: 20,
    x: 40,
    y: 450,
    fill: "red",
    stroke: "black",
    // draggable: true
});

layer.add(player);
stage.add(layer);

var jump = (function() {
    var jumpingFigures = [];

    function jump(player, finished) {
        var x = player.getX(),
            y = player.getY(),
            original = {
                x: x,
                y: y
            },
            CONSTS = {
                JUMP_HT: 300
            },
            updateX = 1,
            updateY = -5;
        if (jumpingFigures.indexOf(player) >= 0) {
            return;
        }
        jumpingFigures.push(player);

        function performJump() {
            if (original.y - CONSTS.JUMP_HT > player.getY()) {
                updateY *= -1;
            }
            player.setX(player.getX() + updateX);
            player.setY(player.getY() + updateY);
            layer.draw();

            if (original.y > player.getY()) {
                requestAnimationFrame(performJump);
            } else {
                jumpingFigures.splice(jumpingFigures.indexOf(player));
                finished();
            }
        }

        performJump();
    }
    return jump;
}());

window.addEventListener('keydown', function(ev) {
    if (ev.keyCode === 32) {
        function muchJump() {
            jump(player, function() {
                muchJump();
            });
        }
        muchJump();
    }
});