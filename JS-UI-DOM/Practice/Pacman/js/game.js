/* globals window document console */
"use strict";
"esversion: 6";

//three.js biblioteka za webGL
const maze = [
    "**** ****************** **********",
    "*    **             *** *        *",
    "* ** ** *********** *** * ****** *",
    "*                       *        *",
    "******* ** *** **** ****** *** ***",
    "        ** ***    * ****** ***    ",
    "**** ** ** ****** *         **** *",
    "*    **           * *** ***      *",
    "* ** ** ****** **** *** ******** *",
    "*    **             ***          *",
    "**** ****************** **********",
],
    ballChar = " ",
    wallChar = "*";

function createGame(pacmanSelector, mazeSelector) {
    var pacmanCanvas = document.querySelector(pacmanSelector),
        ctxPacman = pacmanCanvas.getContext('2d'),
        mazeCanvas = document.querySelector(mazeSelector),
        ctxMaze = mazeCanvas.getContext("2d"),
        isMouthOpen = false,
        pacman = {
            "x": 0,
            "y": 100,
            "size": 18
        },
        balls = [],
        walls = [],
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
        rows = maze.length,
        columns = maze[0].length;

    mazeCanvas.width = (columns) * (pacman.size + 2);
    mazeCanvas.height = (rows) * (pacman.size + 2);
    pacmanCanvas.width = (columns) * (pacman.size + 2);
    pacmanCanvas.height = (rows) * (pacman.size + 2);

    var steps = 0;
    const stepsToChangeMouth = 15;

    function gameLoop() {
        ctxPacman.clearRect(pacman.x - 5, pacman.y - 5, pacman.size + 10, pacman.size + 10);
        drawPacman();

        steps += 1;
        if (0 === (steps % stepsToChangeMouth)) {
            isMouthOpen = !isMouthOpen;
        }
        var index;
        balls.forEach(function (ball, index) {
            if (areColliding(ball, pacman)) {
                ctxMaze.clearRect(ball.x, ball.y, ball.size, ball.size);
                // ball = {
                //     "x": (Math.random() * 600) | 0,
                //     "y": (Math.random() * 100) | 0,
                //     "size": ball.size
                // };
                balls.splice(index, 1);
            }
            // drawBall(ball, "Green", ctxMaze); 
        });

        var isPacmanColiding = isItColliding();

        if (!isPacmanColiding) {
            if (updatePacmanPosition()) {
                ctxPacman.clearRect(0, 0, pacmanCanvas.width, pacmanCanvas.height);
            }
        }
        window.requestAnimationFrame(gameLoop);
    }

    function isItColliding() {
            var isItColiding = false;
            var futurePosition = {
                "x": pacman.x + dirDeltas[dir].x + 1,
                "y": pacman.y + dirDeltas[dir].y + 1,
                "size": pacman.size
            };

            for (var index = 0; index < walls.length; index += 1) {
                var wall = walls[index]; {
                    if (areColliding(wall, futurePosition) || areColliding(futurePosition, wall)) {
                        isItColiding = true;
                    }
                    // drawBall(ball, "Green", ctxMaze); 
                }
            }
            return isItColiding;
        }

    function positionToBound(obj) {
        var sizes = {
            "top": obj.y,
            "left": obj.x,
            "bottom": obj.y + obj.size,
            "right": obj.x + obj.size
        };
        return sizes;
    }

    function isBetween(value, min, max) {
        return min < value && value < max;
    }

    function isExactly(value, min, max) {
        return min === value || value === max;
    }

    function areColliding(obj2, obj1) {
        var sizes1 = positionToBound(obj1);
        var sizes2 = positionToBound(obj2);
        return (isBetween(sizes2.left, sizes1.left, sizes1.right) ||
            isBetween(sizes2.right, sizes1.left, sizes1.right)) &&
            (isBetween(sizes2.top, sizes1.top, sizes1.bottom) ||
                isBetween(sizes2.bottom, sizes1.top, sizes1.bottom));
        /* return ((sizes1.left <= sizes2.left && sizes2.left <= sizes1.right) ||
                (sizes1.left <= sizes2.right && sizes2.right <= sizes1.right)) &&
            ((sizes1.top <= sizes2.top && sizes2.top <= sizes1.bottom) ||
                (sizes1.top <= sizes2.bottom && sizes2.bottom <= sizes1.bottom));  */
        // x1 <= x' <= x2 || x1 <= x'' <= x2
    }

    function drawPacman() {
        var deltaRadians,
            size = pacman.size / 2,
            x = pacman.x + size,
            y = pacman.y + size;
        ctxPacman.fillStyle = "Yellow";
        ctxPacman.beginPath();
        if (isMouthOpen) {
            deltaRadians = dir * Math.PI / 2;
            ctxPacman.arc(x, y, size, deltaRadians + Math.PI / 4, deltaRadians + 7 * Math.PI / 4);
            ctxPacman.lineTo(x, y);
        } else {
            drawBall(pacman, "Yellow", ctxPacman);
        }
        ctxPacman.fill();
    }

    function drawBall(ballToDraw, style, ctx) {
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
        pacman.x += dirDeltas[dir].x;
        pacman.y += dirDeltas[dir].y;

        if (pacman.x < 0 || pacman.x >= pacmanCanvas.width ||
            pacman.y < 0 || pacman.y >= pacmanCanvas.height) {

            pacman.x = (pacman.x + pacmanCanvas.width) % pacmanCanvas.width;
            pacman.y = (pacman.y + pacmanCanvas.height) % pacmanCanvas.height;
            return true;
        }
        return false;
    }

    document.body.addEventListener("keydown", function (ev) {
        console.log(ev.keyCode);
        if (!keyCodeToDir.hasOwnProperty(ev.keyCode)) {
            return;
        }
        if (!isItColliding) {
            
        }
        dir = keyCodeToDir[ev.keyCode];
        console.log(dir);
    });

    function drawMazeAndGetBalls(ctx, maze, cellSize) {
        var row,
            col,
            cell,
            obj,
            balls = [],
            walls = [],
            wallImg = new Image();
        wallImg = document.getElementById("wallImage");
        const ballSize = 8;
        for (var row = 0; row < maze.length; row += 1) {
            for (var col = 0; col < maze[row].length; col += 1) {
                cell = maze[row][col];
                if (cell === ballChar) {
                    obj = {
                        "x": col * cellSize + cellSize / 4,
                        "y": row * cellSize + cellSize / 4,
                        "size": cellSize / 2
                    };
                    balls.push(obj);
                    drawBall(obj, "green", ctx);
                } else if (cell === wallChar) {
                    obj = {
                        "x": col * cellSize,
                        "y": row * cellSize,
                        "size": cellSize
                    };
                    ctx.drawImage(wallImg, obj.x, obj.y, cellSize, cellSize);
                    walls.push(obj);
                }
            }
        }
        return [
            balls,
            walls
        ];
    }

    return {
        "start": function () {
            [balls, walls] = drawMazeAndGetBalls(ctxMaze, maze, 20);
            gameLoop();
        }
    }
}