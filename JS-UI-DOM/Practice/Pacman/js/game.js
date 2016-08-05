/* globals window document console */
"use strict";
//three.js biblioteka za webGL
function createGame(selector) {
    var canvas = document.querySelector(selector),
        ctx = canvas.getContext('2d'),
        isMouthOpen = false,
        pacman = {
            "x": 0,
            "y": 0,
            "size": 60
        },
        dir = 0,
        keyCodeToDir = {
            "37": 2, // 0-right, 1-down, 2-left, 3-up
            "38": 3,
            "39": 0,
            "40": 1
        },
        dirDeltas = [{
            "x": +1,
            "y": 0
        }, {
            "x": 0,
            "y": +1
        }, {
            "x": -1,
            "y": 0
        }, {
            "x": 0,
            "y": -1
        }],
        ball = {
            "x": 200,
            "y": 200,
            "size": 20
        };

    canvas.style.backgroundColor = "black";

    var steps = 0;
    const stepsToChangeMouth = 15;

    function gameLoop() {
        ctx.clearRect(0, 0, canvas.width, canvas.height);
        drawPacman();

        steps += 1;
        if (0 === (steps % stepsToChangeMouth)) {
            isMouthOpen = !isMouthOpen;
        }

        drawBall(ball, "Green");

        if (areColliding(pacman, ball)) {
            ball = {
                "x": (Math.random() * 200) | 0,
                "y": (Math.random() * 100) | 0
            };
        }

        updatePacmanPosition();
        window.requestAnimationFrame(gameLoop);
    }

    function areColliding(obj1, obj2) {
        var 
    }

    function drawPacman() {
        var deltaRadians,
            size = pacman.size / 2,
            x = pacman.x + size,
            y = pacman.y + size;
        ctx.fillStyle = "Yellow";
        ctx.beginPath();
        if (isMouthOpen) {
            deltaRadians = dir * Math.PI / 2;
            ctx.arc(x, y, size, deltaRadians + Math.PI / 4, deltaRadians + 7 * Math.PI / 4);
            ctx.lineTo(x, y);
        } else {
            drawBall(pacman, "Yellow");
        }
        ctx.fill();
    }

    function drawBall(ballToDraw, style) {
        var
            size = ballToDraw.size / 2,
            x = ballToDraw.x + size,
            y = ballToDraw.y + size;
        ctx.fillStyle = style;
        ctx.beginPath();
        ctx.arc(x, y, size, 0, Math.PI * 2);
        ctx.fill();
    }

    function updatePacmanPosition() {
        pacman.x += 4 * dirDeltas[dir].x;
        pacman.y += 4 * dirDeltas[dir].y;

        pacman.x = (pacman.x + canvas.width) % canvas.width;
        pacman.y = (pacman.y + canvas.height) % canvas.height;
    }

    document.body.addEventListener("keydown", function(ev) {
        console.log(ev.keyCode);
        if (!keyCodeToDir.hasOwnProperty(ev.keyCode)) {
            return ';'
        }
        dir = keyCodeToDir[ev.keyCode];
        console.log(dir);
    });

    return {
        "start": function() {
            gameLoop();
        }
    }
}