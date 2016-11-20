/* globals XMLHttpRequest */

var url = "http://localhost:8886/api/people";

function sendHTTPRequest(serviceUrl, method, body, callback) {
    // 1. Create the xhr
    var xhr = new XMLHttpRequest();

    // 2. Open the XHR to URL and Verb
    xhr.open(method, serviceUrl, true);

    // 3. Setup

    // 3.1 Add headers
    xhr.setRequestHeader("Content-Type", "application/json");
    // 4. Arrach to ready event
    xhr.onreadystatechange = function() {

        console.log(`State: ${xhr.readyState}`);

        // Validate if it works
        if (xhr.readyState != XMLHttpRequest.DONE) {
            return;
        }

        // proverqvame status koda
        switch (0 | xhr.status / 100) {
            // ako e 200 prodaljavame logikata
            case 2:
                callback(JSON.parse(xhr.responseText).data);
                break;
            case 4:
                // ako e 500 preduprejdavame za greshka
            case 5:
                alert(xhr.response);
                break;
        }
    };
    // 5. Send the request
    xhr.send(body);
}

function getAll() {
    sendHTTPRequest(url, "GET", null, function(data) {
        var people = data;
        // syzdavame prost template na elementi, koito shte polzvame
        var itemTemplate = document.createElement("li");
        itemTemplate.innerText = "Name: ";
        var list = document.createElement("ul");
        var strong = document.createElement("strong");
        // zakachame dannite kym klonirani "li" elementi v obshtiq list
        people.forEach(person => {
            var li = itemTemplate.cloneNode(true),
                str = strong.cloneNode(true);
            str.innerHTML = `${person.name}<span>, Age: </span>${person.age}`;
            li.appendChild(str);
            list.appendChild(li);
        });
        // zakachame spisaka kym DOM dyrvoto
        document.getElementById("print").appendChild(list);
    });
}

function addNew() {
    var name = "John" + Math.random().toFixed(2),
        age = Math.random().toFixed(2) * 150;

    sendHTTPRequest(url, "POST", JSON.stringify({ name: name, age: age }), function() {
        getAll();
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