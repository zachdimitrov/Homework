function wrt(iid, txt) {
    var x = document.getElementById(iid);
    x.innerHTML = txt;
}

function newField(id) {
    var z = document.getElementById(id);
    z.innerHTML += '<input type="number" value="0">';
}

function showS(id) {
    document.getElementById(id).style.display = 'block';
    document.getElementById(id).style.zIndex = -1;
}

function changeS(id, color, bgcolor, weight) {
    document.getElementById(id).style.color = color;
    document.getElementById(id).style.backgroundColor = bgcolor;
    document.getElementById(id).style.fontWeight = weight;
}

function hideS() {
    var ids = [].slice.apply(arguments);
    for (var i = 0; i < ids.length; i++) {
        var id = ids[i];
        document.getElementById(id).style.display = 'none';
    }
}