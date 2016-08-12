function createImagesPreviewer(selector, items) {
    var root = document.querySelector(selector),
        imagePreviewer = document.createElement('div'),
        aside = document.createElement('div'),
        fragment = document.createDocumentFragment(),
        input = document.createElement('input'),
        inputHeader = document.createElement('h3'),
        listOfItems = document.createElement('ul'),
        li = document.createElement('li'),
        imageHeader = document.createElement('h3'),
        image = document.createElement('img'),
        selectedParent = document.createElement('div'),
        selectedImageHeader = document.createElement('h3'),
        selectedImage = document.createElement('img');

    root.style.fontFamily = 'sans-serif';
    selectedImageHeader.innerText = items[0].title;
    selectedImage.src = items[0].url;
    selectedImage.style.width = '80%';
    selectedParent.classList.add('image-preview');
    li.classList.add('image-container');

    image.style.width = '100%';
    image.style.borderRadius = '10px';
    selectedImage.style.borderRadius = '10px';

    listOfItems.style.listStyleType = 'none';
    listOfItems.style.height = '400px';
    listOfItems.style.overflow = 'scroll';
    listOfItems.style.paddingLeft = '30px';
    listOfItems.style.paddingRight = '10px';
    imagePreviewer.style.display = 'inline-block';
    imagePreviewer.style.width = '75%';
    imagePreviewer.style.float = 'left';
    imagePreviewer.style.textAlign = 'center';
    input.style.width = '75%';
    input.style.height = '40px';
    input.style.fontSize = '25px';

    aside.style.display = 'inline-block';
    aside.style.width = '25%';
    aside.style.textAlign = 'center';

    inputHeader.innerText = 'Select';
    aside.appendChild(inputHeader);
    aside.appendChild(input);
    aside.appendChild(listOfItems);

    fragment.appendChild(imagePreviewer);
    fragment.appendChild(aside);
    root.appendChild(fragment);
    imagePreviewer.appendChild(selectedImageHeader);
    selectedParent.appendChild(selectedImage);
    imagePreviewer.appendChild(selectedParent);

    listOfItems.addEventListener('click', function(ev) {
        var target = ev.target;
        if (target.tagName === 'IMG') {
            var header = target.previousElementSibling.innerText;
            var sorc = target.src;
            selectedImageHeader.innerText = header;
            selectedImage.src = sorc;
        };
    }, false);

    listOfItems.addEventListener('mouseover', function(ev) {
        var target = ev.target;
        if (target.tagName === 'IMG') {
            target.parentElement.style.backgroundColor = 'lightgray';
            target.style.cursor = 'pointer';
        };
    }, false);

    listOfItems.addEventListener('mouseout', function(ev) {
        var target = ev.target;
        if (target.tagName === 'IMG') {
            target.parentElement.style.backgroundColor = '';
        };
    }, false);

    input.addEventListener('keyup', function(ev) {
        var target = ev.target;
        var text = target.value;
        var liChildren = listOfItems.getElementsByTagName('LI');
        for (var i = 0, len = liChildren.length; i < len; i += 1) {
            var currentLi = liChildren[i];
            var header = currentLi.firstElementChild.innerText;
            if (header.toLowerCase().indexOf(text.toLowerCase()) >= 0) {
                currentLi.style.display = 'block';
            } else {
                currentLi.style.display = 'none';
            }
        }
    }, false);

    for (var i = 0, len = items.length; i < len; i += 1) {
        var currentItem = items[i];
        var currentLi = li.cloneNode(true);
        var currentImageHeader = imageHeader.cloneNode(true);
        currentImageHeader.innerText = currentItem.title;
        var currentImage = image.cloneNode(true);
        currentImage.src = currentItem.url;

        currentLi.appendChild(currentImageHeader);
        currentLi.appendChild(currentImage);
        listOfItems.appendChild(currentLi);
    }
}