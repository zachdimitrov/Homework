/* globals document, window, console */

function solve() {
    return function(selector, initialSuggestions) {

        var root = document.querySelector(selector),
            sugList = document.querySelector('.suggestions-list'),
            input = document.querySelector('.tb-pattern'),
            button = document.querySelector('.btn-add');

        function createList(e) {
            var sugLi = document.createElement('li');
            sugLi.className += ' suggestion';
            sugLi.style.display = 'none';
            var sug = document.createElement('a');
            sug.className += ' suggestion-link';
            sug.innerHTML = e;
            sug.setAttribute('href', '#');
            sugLi.appendChild(sug);
            return sugLi;
        }

        if (initialSuggestions) {

            var initial = initialSuggestions,
                i, e, len = initial.length;

            if (initial.length > 1) {
                for (i = 0; i < len; i++) {
                    for (e = 0; e < len; e++) {
                        if (initial[e] && initial[i] && initial[e].toLowerCase() === initial[i].toLowerCase() && (i != e)) {
                            delete initial[e];
                            if (initial.length <= 1) {
                                return;
                            }
                        }
                    }
                }
            }

            initial.forEach(function(element) {
                if (element) {
                    sugList.appendChild(createList(element));
                }
            });
        }

        input.addEventListener('input', function(ev) {

            var pattern = this.value.toLowerCase();
            var sugs = document.querySelectorAll('.suggestion-link');
            var i, len;

            for (i = 0, len = sugs.length; i < len; i++) {
                var isPatternFound = (sugs[i].innerHTML
                        .toLowerCase()
                        .indexOf(pattern) >= 0) &&
                    (pattern.length > 0);

                if (isPatternFound) {
                    sugs[i].parentNode.style.display = '';
                } else {
                    sugs[i].parentNode.style.display = 'none';
                }
            }
        });

        button.addEventListener('click', function(ev) {
            var target = ev.target,
                i,
                len;
            var ss = document.querySelectorAll('.suggestion-link');
            for (i = 0, len = ss.length; i < len; i++) {
                if (!ss[i] || ss[i].innerText.toLowerCase().trim() === input.value.toLowerCase().trim()) {
                    return;
                }
            }
            if (target.className.indexOf('btn-add') >= 0 && input.value.length > 0) {
                sugList.appendChild(createList(input.value));
            }
            input.value = '';
        });

        sugList.addEventListener('mouseover', function(ev) {
            var target = ev.target;
            if (target.className.indexOf('suggestion-link') < 0) {
                return;
            }
            target.style.cursor = "pointer";
        });

        sugList.addEventListener('click', function(ev) {
            var target = ev.target;
            if (target.className.indexOf('suggestion-link') < 0) {
                target = target.children;
            }
            input.value = target.innerHTML;
        });
    };
}

module.exports = solve;