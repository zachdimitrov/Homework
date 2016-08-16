/* globals $ */
$.fn.gallery = function(columnsPerRow) {
    columnsPerRow = columnsPerRow || 4;

    var $gallery = $(this);
    var $selected = $gallery.children('.selected');
    var $galleryList = $gallery.children('.gallery-list');
    var $imageContainers = $galleryList.children('.image-container');
    var $currentImage = $selected.find('#current-image');
    var $previousImage = $selected.find('#previous-image');
    var $nextImage = $selected.find('#next-image');


    $imageContainers.each(function(index, element) {
        if (index % columnsPerRow == 0) {
            $(element).addClass('clearfix');
        }
    });

    $galleryList.on('click', 'img', function() {
        var $this = $(this);
        $galleryList.addClass('blurred');
        $('<div />').addClass('disabled-background').appendTo($gallery);
        applySelected($(this));

        $selected.show();
    });

    $currentImage.on('click', function() {
        $selected.hide();
        $galleryList.removeClass('blurred');
        $gallery.children('.disabled-background').remove();
    });

    $previousImage.on('click', function() {
        applySelected($(this));
    });

    $nextImage.on('click', function() {
        applySelected($(this));
    });

    $gallery.addClass('gallery');
    $selected.hide();

    function applySelected($element) {
        var currentImageInfo = getImageInfo($element);
        setImageInfo($currentImage, currentImageInfo.src, currentImageInfo.index);
        var previousIndex = getPrevIndex(currentImageInfo.index);
        var nextIndex = getNextIndex(currentImageInfo.index);
        var previousImage = getImageByIndex(previousIndex);
        var nextImage = getImageByIndex(nextIndex);
        var previousImageInfo = getImageInfo(previousImage);
        var nextImageInfo = getImageInfo(nextImage);
        setImageInfo($previousImage, previousImageInfo.src, previousImageInfo.index);
        setImageInfo($nextImage, nextImageInfo.src, nextImageInfo.index);
    }

    function getImageByIndex(index) {
        return $gallery.find('img[data-info="' + index + '"]')
    }

    function getImageInfo($element) {
        return {
            src: $element.attr('src'),
            index: parseInt($element.attr('data-info'))
        };
    }

    function setImageInfo($element, src, index) {
        $element.attr('src', src);
        $element.attr('data-info', index);
    }

    function getNextIndex(index) {
        index++;
        if (index > $imageContainers.length) {
            index = 1;
        }
        return index;
    }

    function getPrevIndex(index) {
        index--;
        if (index < 1) {
            index = $imageContainers.length;
        }
        return index;
    }

    return this;
};