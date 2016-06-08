//Problem 1 - Numbers
wrt('pro51', 'Problem 1.  Increase array members' + '<br>');

function IncreaseArray() {
    var info = document.getElementById('n51');
    var n = +info.elements[0].value;
    var d = +info.elements[1].value;
    var arr = [];
    for (var i = 0; i < n; i += 1) {
        arr[i] = i * d;
    }
    wrt('pr51', arr.join(', '));
}