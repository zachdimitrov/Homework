/* globals XMLHttpRequest */

var url = "http://localhost:8886/api/people";

function getAll() {
    $.getJSON(url, function(responce) {
        var people = responce.data;
        var itemTemplate = document.createElement("li");
        itemTemplate.innerText = "Name: ";
        var list = document.createElement("ul");
        var strong = document.createElement("strong");
        people.forEach(person => {
            var li = itemTemplate.cloneNode(true),
                str = strong.cloneNode(true);
            str.innerHTML = `${person.name}<span>, Age: </span>${person.age}`;
            li.appendChild(str);
            list.appendChild(li);
        });
        document.getElementById("print").innerHTML = "";
        document.getElementById("print").appendChild(list);
    });
}

function addNew() {
    var name = "John" + Math.random().toFixed(2),
        age = Math.random().toFixed(2) * 150;

    $.ajax({
        url: url,
        method: "POST",
        "contentType": "application/json",
        data: JSON.stringify({ name, age }),
        success: function() {
            getAll();
        }
    });
}

var btn;
window.onload = function() {
    getAll();
    btn = document.getElementById("btn-add");
    btn.addEventListener("click", function() {
        addNew();
    });
}