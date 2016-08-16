function createCountriesList(countries) {
    var $countriesList = $('<ul class="countries-list" />');
    $(countries).each(function(index, country) {
        $countriesList.append(
            $('<li />')
            .addClass('country-item')
            .html(country.name + ' (population: ' + country.population + '; capital: ' + country.capital + ')')
        );
    });
    return $countriesList;
}
$(function() {
    // attach on 'keyup' for live update 
    // 'change' fires when the focus is lost
    $("#tb-filter").on('keyup', function() {
        var value = $(this).val().toLowerCase();
        if (value.length < 1) {
            $('#countries').html('');
            return;
        }

        $.get('http://restcountries.eu/rest/v1/name/' + value)
            .success(function(respCountries) {
                var $countriesList = createCountriesList(respCountries);
                $('#countries').html($countriesList);
            });
    });
});

// http://www.sitepoint.com/jquery-vs-raw-javascript-3-events-ajax