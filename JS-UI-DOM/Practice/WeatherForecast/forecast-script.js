var wrapper = document.getElementById('wrapper'),
    template = document.getElementById('template'),
    h2 = document.createElement('h2'),
    forecastCont = document.createElement('ul'),
    detailCont = document.createElement('div'),
    dayLi = document.getElementsByClassName('day-forecast')[0],
    dateCont = document.getElementsByClassName('date-cont')[0],
    imgTag = document.getElementsByClassName('forecast-icon')[0],
    tempCont = document.getElementsByClassName('temp-cont')[0],
    list = data.list,
    baseIconUrl = 'http://openweathermap.org/img/w/';

//dayLi = document.createElement('li'),
//imgTag = document.createElement('img'),
//dateCont = document.createElement('div'),
//tempCont= document.createElement('div'),

forecastCont.id = 'weather-forecast';
detailCont.id = 'details-cont';
h2.innerText = 'Weather forecast for ' + data.city.name;
wrapper.appendChild(h2);


for (var i = 0, len = list.length; i < len; i += 1) {
    let day = list[i];
    dayLi.id = 'day-forecast' + i;
    dateCont.innerText = (new Date(day.dt * 1000)).toDateString().substr(0, 11);
    imgTag.src = baseIconUrl + day.weather[0].icon + '.png';
    tempCont.innerText = day.temp.day.toFixed(1) + ' °C';

    dayLi.setAttribute('data-index', i);

    forecastCont.appendChild(dayLi.cloneNode(true));
}

forecastCont.addEventListener('click', function(ev) {
    let index, selectedDate;
    if (ev.target.hasAttribute('data-index')) {
        index = ev.target.getAttribute('data-index');
    } else {
        index = ev.target.parentElement.getAttribute('data-index');
    }
    selectedDate = list[index];
    detailCont.innerText = JSON.stringify(selectedDate);
}, false);

wrapper.appendChild(forecastCont);
wrapper.appendChild(detailCont);