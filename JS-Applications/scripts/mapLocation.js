function initMap() {
    navigator.geolocation.getCurrentPosition(function success(pos) {
        console.log(pos);
        // Create a map object and specify the DOM element for display.
        var map = new google.maps.Map(document.getElementById('map'), {
            center: { lat: pos.coords.latitude, lng: pos.coords.longitude },
            scrollwheel: false,
            zoom: 15
        });
    }, function error(data) {
        console.log(data);
    });
}