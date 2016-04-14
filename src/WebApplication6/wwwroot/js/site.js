// Write your Javascript code.


function initAutocomplete() {

    // Create the search box and link it to the UI element.
    var input = /** @type {!HTMLInputElement} */ document.getElementById('searchbar');
    var submitbtn = document.getElementById('submit-search');
    var autocomplete = new google.maps.places.Autocomplete(input, {
        types: ['(cities)'], // Geocodes only
        componentRestrictions: {
            //country: 'AU' // Limit me to Australia.
        }
    });
    //submitbtn.onsubmit(function (e) {
    //    e.preventDefault();
    //});

    // prevent form to be submitted on enter
    //google.maps.event.addDomListener(input, 'keydown', function (e) {
    //    if (e.keyCode === 13) {
    //        e.preventDefault();
    //    }
    //});

    submitbtn.addEventListener("click", function () {
        google.maps.event.trigger(autocomplete, 'place_changed');
    });

    //$('.searchbar').keypress(function (e) {
    //    if (e.which == 13) {
    //        google.maps.event.trigger(autocomplete, 'place_changed');
    //        return false;
    //    }
    //});
    //google.maps.event.addDomListener(input, 'keydown', function (e) {
    //    if (e.keyCode == 13) {
    //        alert('skip');
    //        e.preventDefault();
    //    }
    //});



    //Add listener to search
    //searchform.addEventListener("submit", function () {
    //    if (!place.geometry) {
    //        window.alert("Autocomplete's returned place contains no geometry");
    //        return;
    //    }
    //    var address = place.formatted_address;
    //    var latitude = place.geometry.location.lat();
    //    var longitude = place.geometry.location.lng();
    //    var mesg = "Address: " + address;
    //    mesg += "\nLatitude: " + latitude;
    //    mesg += "\nLongitude: " + longitude;
    //    alert(mesg);

    //});

    autocomplete.addListener('place_changed', function () {
        var place;
        place = autocomplete.getPlace();
        if (!place || !place.geometry) {
            window.alert("Autocomplete's returned place contains no geometry");
            return;
        }
        var address = place.formatted_address;
        var latitude = place.geometry.location.lat();
        var longitude = place.geometry.location.lng();
        var mesg = "Address: " + address;
        mesg += "\nLatitude: " + latitude;
        mesg += "\nLongitude: " + longitude;
        alert(mesg);
    });
}