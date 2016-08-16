/* globals module */

function createImagesPreviewer(selector, items) {
    var root = document.querySelector(selector); // vzimame samo pyrviq
    var left = document.createElement('div'),
        right = document.createElement('div');

    root.style.fontFamily = 'sans-serif';

    // left
    left.calssName += ' image-preview';
    left.style.float = 'left';
    left.style.width = '70%';

    // left - image - preview
    var title = document.createElement('h2');
    title.innerText = animals[0].title;
    title.style.textAlign = 'center';
    var img = document.createElement('img');
    img.src = animals[0].url;
    img.style.width = '90%';
    img.style.marginLeft = '25px';
    img.style.borderRadius = '10px';
    left.appendChild(title);
    left.appendChild(img);

    // right
    right.style.float = 'left';
    right.style.width = '25%';

    // right - filter
    var label = document.createElement('label');
    label.innerHTML = '<h2>Filter</h2>';
    label.style.display = 'block';
    var filter = document.createElement('input');
    filter.style.width = '98%';
    filter.style.fontSize = '1.5em';
    filter.style.marginBottom = '20px';
    var id = 'input-id-' + Math.random();
    filter.id = id;

    label.setAttribute('for', id);
    right.appendChild(label);
    right.appendChild(filter);

    // right - image - list
    var imagesList = document.createElement('div');
    imagesList.id = 'ilist';
    var height = window.innerHeight;
    imagesList.style.height = height - 150 + 'px';
    imagesList.style.overflowY = 'scroll';
    imagesList.style.paddingRight = '10px';
    right.appendChild(imagesList);

    animals.forEach(function (an) {
        var title = document.createElement('strong');
        title.style.display = 'block';
        var img = document.createElement('img');
        img.style.width = '100%';
        img.src = an.url;
        img.style.borderRadius = '10px';
        title.innerHTML = an.title;
        title.style.textAlign = 'center';
        var parent = document.createElement('div');
        parent.className += ' image-container';
        parent.style.paddingBottom = '15px';
        parent.appendChild(title);
        parent.appendChild(img);
        imagesList.appendChild(parent);
    });

    imagesList.addEventListener('mouseover', function(ev){
        var target = ev.target;
        while(target.className.indexOf('image-container') < 0) {
            target = target.parentNode;
        }
        target.style.backgroundColor = 'pink';
    });

    imagesList.addEventListener('mouseout', function(ev) {
        var target = ev.target;
        while(target.className.indexOf('image-container') < 0) {
            target = target.parentNode;
        }
        target.style.backgroundColor = '';
    });

    imagesList.addEventListener('click', function(ev) {
        var target = ev.target;
        while(target.className.indexOf('image-container') < 0) {
            target = target.parentNode;
        }
        smallimg = target.querySelector('img');
       smalltitle = target.querySelector('strong');
       img.src = smallimg.src;
       title.innerHTML = smalltitle.innerHTML;
    });

    filter.addEventListener('input', function(ev) {
        var pattern = this.value.toLowerCase();
        var titles = imagesList.querySelectorAll('strong');
        var i, len;
        for (i = 0, len = titles.length; i < len; i++) {
            var isPatternFound = titles[i].innerHTML
            .toLowerCase()
            .indexOf(pattern) >= 0;
            if (isPatternFound) {
                titles[i].parentNode.style.display = '';
            } else {
                titles[i].parentNode.style.display = 'none';
            }
        }
    });

    root.appendChild(left);
    root.appendChild(right);
}