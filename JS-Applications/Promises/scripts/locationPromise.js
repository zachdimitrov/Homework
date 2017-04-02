(function() {
    // tuk deklarirame promise
    var myPromise = new Promise((resolve, reject) => {
            navigator.geolocation.getCurrentPosition((position) => {
                resolve(position);
            });
        }),
        obj = {};
    // tova sa funkciite, koito se polzvat
    function parsePos(position) {
        obj.pos = {
            lat: position.coords.latitude,
            lng: position.coords.longitude
        }

        return obj;
    }

    function displayMap(obj) {
        obj.src = `https://maps.googleapis.com/maps/api/staticmap?center=${obj.pos.lat},${obj.pos.lng}&zoom=17&size=500x500&key=AIzaSyA66MMq38FBzDEA_RZoDBX_rTvUcYE-VPA`;
        obj.head = document.getElementById('heading');
        obj.div = document.getElementById('static');
        obj.img = document.createElement('img');
        obj.head.innerHTML = `<h1>KARTINKA NA KOORDINATI</h1>
        <p>${obj.pos.lat}</p>
        <p>${obj.pos.lng}</p>`;
        obj.img.setAttribute('src', obj.src);
        obj.div.appendChild(obj.img);

        return obj;
    }

    // startirane na promise
    // vsqka sledvashta funkciq poluchava parametara ot predishnata funkciq

    myPromise
        .then(parsePos)
        .then(displayMap)
        .then(console.log)
        .catch((err) => { console.log(err) });
}());