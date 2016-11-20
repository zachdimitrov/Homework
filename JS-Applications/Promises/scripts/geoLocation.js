(function() {
    navigator.geolocation.getCurrentPosition(function success(pos) {
        console.log(pos);
        var src = "https://maps.googleapis.com/maps/api/staticmap?center=" +
            pos.coords.latitude + "," + pos.coords.longitude +
            "&zoom=17&size=500x500",
            div = document.getElementById('static'),
            img = document.createElement('img');
        img.setAttribute('src', src);
        div.appendChild(img);
    }, function error(data) {

    });
}());