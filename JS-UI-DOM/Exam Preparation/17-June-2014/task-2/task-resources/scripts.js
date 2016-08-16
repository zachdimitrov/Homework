/* globals $ */
$.fn.gallery = function(columns) {
    columns = columns || 4;
    var $this = this;
    $this.addClass('gallery');
    var $selected = $this.find('.selected');
    
    var count = 0;
    var imageCont = $this.find('.image-container');
    imageCont.each(function(index, imageCont) {
        count += 1;
        if (count == columns) {
            var $imageCont = $(imageCont); 
            $imageCont.after($('<div/>').addClass('clearfix'));
            count = 0;
        }
    });

    $('.gallery').on('click', '.image-container', function() {
        $selected.show();
    });
    $this = this;
    $selected.hide();
    return this;
};