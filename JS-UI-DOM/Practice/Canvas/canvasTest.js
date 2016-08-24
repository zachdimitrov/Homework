// initialise
var canvas = document.getElementById('the-canvas'),
    ctx = canvas.getContext('2d');
// rectangle
ctx.fillStyle = 'red';
ctx.fillRect(50, 50, 75, 50); // top-left: x, y, width, height
ctx.strokeStyle = 'white';
ctx.lineWidth = 3;
ctx.strokeRect(150, 50, 75, 50);

ctx.fillStyle = 'rgba(100, 20, 23, 0.3)';
ctx.fillRect(200, 80, 50, 30);

ctx.beginPath();

ctx.moveTo(40, 80);
ctx.lineTo(50, 120);
ctx.lineTo(200, 250);
ctx.lineTo(500, 60);
ctx.closePath();
ctx.fillStyle = 'rgba(20, 200, 123, 0.5)';
ctx.fill();

ctx.stroke();

// circle

ctx.lineWidth = 2;
ctx.strokeStyle = 'black';
ctx.fillStyle = 'lightblue';

ctx.beginPath();
var x = 300,
    y = 120,
    r = 80;

ctx.moveTo(x + r, y);
ctx.arc(x, y, r, 0, 2 * Math.PI); // center: x, y, radius, start(rad), end(rad)
ctx.stroke();
ctx.beginPath();
ctx.moveTo(x - 200, y);
ctx.arc(x - 200, y, r, 0, 1.2 * Math.PI); // center: x, y, radius, start(rad), end(rad)
ctx.closePath();
ctx.stroke();
ctx.fill();

// curves

ctx.lineWidth = 1;
ctx.strokeStyle = 'blue';

ctx.moveTo(400, 20);
ctx.lineTo(500, 200);
ctx.quadraticCurveTo(100, 200, 200, 20);
ctx.closePath();
ctx.stroke();

function quadCurve(ctx, s1, s2, c1) {
    ctx.beginPath();
    ctx.moveTo(s1.x, s1.y);
    ctx.quadraticCurveTo(c1.x, c1.y, s2.x, s2.y); // quadratic curve
    ctx.stroke();
}

function bezierCurve(ctx, s1, s2, c1, c2) {
    ctx.beginPath();
    ctx.moveTo(s1.x, s1.y);
    ctx.bezierCurveTo(c1.x, c1.y, c2.x, c2.y, s2.x, s2.y); // bezier curve
}

var s1 = { x: 30, y: 10 };
var s2 = { x: 500, y: 10 };
var i = 1;

function anim() {
    ctx.clearRect(0, 0, canvas.width, canvas.height);
    var c1 = { x: i * 20 - 300, y: 20 + i * 10 };
    var c2 = { x: 500 + i * 10, y: i * 20 };
    i += 0.2;
    if (i > 30) {
        return;
    }
    quadCurve(ctx, s1, s2, c1);
    bezierCurve(ctx, s1, s2, c1, c2);
    requestAnimationFrame(anim);
    //setTimeout(anim, 100);
}

//anim();

// text

ctx.fillStyle = 'purple';
ctx.strokeStyle = 'orange';
ctx.font = 'bold italic 100px Arial';

ctx.save();
ctx.setLineDash([5, 2]);
ctx.lineWidth = 3;
ctx.fillText('John', 50, 150);
ctx.strokeText('John', 50, 150);
ctx.strokeText('Stamo', 300, 150);
ctx.restore();


// scaling
ctx.clearRect(0, 0, canvas.width, canvas.height); // remove this to show upper

ctx.fillRect(100, 100, 100, 100);
ctx.fillStyle = 'white';
ctx.save(); // saves the canvas to current state

ctx.scale(1, 0.5); // scales the context
ctx.fillRect(300, 100, 100, 100);

ctx.fillStyle = 'blue';
ctx.beginPath();
ctx.arc(300, (1 / 0.5) * 150, 50, 0, 2 * Math.PI); // way to create ellipse
ctx.fill();
ctx.restore();

ctx.save();
ctx.fillStyle = 'yellow';
ctx.beginPath();
ctx.rotate(0.3); // rotates the whole canvas from the top left corner
ctx.scale(1, 0.5);
ctx.arc(420, (1 / 0.5) * 150, 50, 0, 2 * Math.PI); // way to create ellipse
ctx.fill();
ctx.restore();

ctx.restore(); // retores the canvas to previous save
ctx.fillStyle = 'orange';
ctx.fillRect(500, 100, 100, 100);

// pixel manipulation
ctx.clearRect(0, 0, canvas.width, canvas.height);
ctx.strokeStyle = 'black';
var j = 0,
    count = 100;
for (var i = 0; i < count; i += 1) {
    ctx.fillRect(i * 5, i * 3.5, 50, 100);
    ctx.strokeRect(i * 5, i * 3.5, 50, 100);
}

var imageData = ctx.getImageData(50, 50, 200, 200);

var data = imageData.data; // this is array of pixel data [r,g,b,a, r,g,b,a ...]
for (var i = 0, len = data.length; i < len; i += 4) {
    data[i] = 255 - data[i]; // c0lor value 'R'
    data[i + 1] = 255 - data[i + 1]; // color value 'G'
    data[i + 2] = 0; // color value 'B'
    data[i + 3] = 0.002 * i; // opacity value 'Alfa'

    var color = {
        red: imageData.data[i],
        green: imageData.data[i + 1],
        blue: imageData.data[i + 2],
        alfa: imageData.data[i + 3],
    }
}

ctx.putImageData(imageData, 50, 50);

// draw images

// var img = document.querySelector('img');
var img = new Image();
img.onload = function() {
    ctx.drawImage(img, 50, 50, 100, 100);
};

img.src = 'http://downloads.andyroid.net/website/v2//wp-content/uploads/2015/04/peppa-pig-icon.png';

var imageData = ctx.getImageData(0, 0, canvas.width, canvas.height);
data = imageData.data;
for (var i = 0; i < data.length; i += 4) {
    var color = {
        red: data[i],
        green: data[i + 1],
        blue: data[i + 2],
        alfa: data[i + 3]
    };
    if (color.red === 0, color.green === 0, color.blue > 0) {
        data[i + 3] = 0;
    }
}
ctx.putImageData(imageData, 0, 0);