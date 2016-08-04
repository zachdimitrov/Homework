/* globals window document console */
"use strict";

function createGame(selector) {
    var canvas = document.querySelector(selector),
        ctx = canvas.getContext('2d'),
        isMouthOpen = false,
        pacman = {
            "x": 30,
            "y": 30,
            "size": 30
        };
    //three.js biblioteka za webGL
    canvas.style.backgroundColor = "black";
    ctx.fillStyle = "Yellow";

    var steps = 0;
    const stepsToChangeMouth = 15;

    function gameLoop() {
        if (isMouthOpen) {
            ctx.clearRect(0, 0, canvas.width, canvas.height);
            ctx.beginPath();
            ctx.arc(pacman.x, pacman.y, pacman.size, Math.PI / 4, 7 * Math.PI / 4);
            ctx.lineTo(pacman.x, pacman.y);
        } else {
            ctx.arc(pacman.x, pacman.y, pacman.size, 0, Math.PI * 2);
        }
        ctx.fill();
        steps += 1;
        if (0 === (steps % stepsToChangeMouth)) {
            isMouthOpen = !isMouthOpen;
        }

        window.requestAnimationFrame(gameLoop);
    }

    return {
        "start": function() {
            gameLoop();
        }
    }
}