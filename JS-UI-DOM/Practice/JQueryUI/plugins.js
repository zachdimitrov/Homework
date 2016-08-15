/* globals, jquery */
(function($) {
    $.fn.alertMe = function() {
        var clicked = true;
        $(this).on("click", function() {
                if (clicked) {
                    $(this).css({
                        "color": "red",
                        "padding": "25px",
                        "background-color": "yellow"
                    });
                    clicked = false;
                } else {
                    $(this).css({
                        "color": "darkblue",
                        "padding": "20px",
                        "background-color": "#ccc"
                    });
                    clicked = true;
                }
                //alert("didozavak");
            })
            .css({
                "color": "darkblue",
                "display": "inline-block",
                "border": "1px solid green",
                "border-radius": "10px",
                "padding": "20px",
                "width": "40%",
                "text-align": "center",
                "font-family": "sans-serif",
                "background-color": "#CCC",
            });
    }
}(jQuery));