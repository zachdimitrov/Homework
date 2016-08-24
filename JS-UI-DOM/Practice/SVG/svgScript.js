// generate SVG element
var svg = document.getElementById('the-svg');
var svgNs = 'http://www.w3.org/2000/svg';
// create rectangle
var rect = document.createElementNS(svgNs, 'rect');
rect.setAttribute('x', 50);
rect.setAttribute('y', 75);
rect.setAttribute('width', 50);
rect.setAttribute('height', 70);
//rect.setAttribute('fill', 'none');
//rect.setAttribute('stroke', 'orange');
svg.appendChild(rect);

var special = document.querySelector('#special');

var delta = 1;

console.log(rect.getAttribute('x') + ' ' + svg.getAttribute("width"));

function frame() {
    var x = +rect.getAttribute('x');

    if (x > +svg.getAttribute("width")) {
        delta *= -1;
    }

    rect.setAttribute('x', x + delta * 5);

    requestAnimationFrame(frame);
}

frame();

var path = document.querySelector('#special-path');