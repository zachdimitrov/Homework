function solve() {
    return function(selector) {
        var elm,
            buttons;

        if (typeof(selector) === 'string') {
            elm = document.getElementById(selector);
            if (!elm) {
                throw new Error();
            }
        } else if (!(selector instanceof HTMLElement)) {
            throw new Error();
        } else {
            elm = selector;
        }

        buttons = elm.getElementsByClassName('button');

        for (var ob in buttons) {
            var element = buttons[ob];
            element.innerHTML = 'hide';
        }

        elm.addEventListener('click', function(ev) {
            var cont = ev.target.nextElementSibling;
            if (ev.target.className === 'button') {
                if (cont.tagName === 'BR') {
                    cont = cont.nextElementSibling;
                }
                if (cont.className === 'content') {
                    if (cont.style.display === '') {
                        cont.style.display = 'none';
                        ev.target.innerHTML = 'show';
                        return;
                    }
                    if (cont.style.display === 'none') {
                        cont.style.display = '';
                        ev.target.innerHTML = 'hide';
                        return;
                    }
                }
            }
        }, false);
    };
}

module.exports = solve;
