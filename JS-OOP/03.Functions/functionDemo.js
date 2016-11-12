function customLog(message) {
    var nextdiv = document.createElement("div");
    nextdiv.innerHTML = message;
    document.body.appendChild(nextdiv);
    // console.log(message);
}

(function() {

    customLog("------------------- example 1");
    // print arguments

    function myFunc() {
        customLog(arguments); // will print the arguments object
    }
    myFunc("zahari", true, 34);

    customLog("------------------- example 2");
    // max number of array

    function max(arr) {
        if (Array.isArray(arr)) {
            var max = arr[0];
            arr.forEach(n => max = Math.max(n, max));
            return max;
        } else {
            customLog("Ne si podal masiv!")
        }
    }

    customLog(max([2, 45, 1, 232, 772, 22]));
    customLog(["edno", "dve", "tri"]);
    customLog("------------------- example 3");
    // sum of items

    function sum(...items) {
        if (Array.isArray(items[0])) {
            items = items[0];
        }

        let itemsSum = 0;
        // if (typeof items[0] !== "number") {
        //     itemsSum = "";
        // }

        items.forEach(function(item) {
            itemsSum += item;
        }, this);

        // for (let item of items) {
        //     itemsSum += item;
        // }

        return itemsSum;
    }

    customLog("......add number of elements..........");
    var countfield = document.createElement("input");
    countfield.setAttribute("type", "number");
    document.body.appendChild(countfield);
    customLog("......add value for each element......");
    var number = 0;
    var nextdiv = document.createElement("div");
    countfield.onchange = function() {
        number = this.value;
        nextdiv.innerHTML = number;
        countfield.parentNode.insertBefore(nextdiv, countfield.nextSibling);
        var numbers = [];
        for (var i = 0; i < number; i += 1) {
            numbers[i] = (Math.random() * 100).toFixed(1);
        }

        customLog(numbers);
        customLog(sum(numbers));
    }


    customLog(sum(4, 5, 6));
    customLog(sum([20, 345, 87], [22983, 221], 8));
    customLog(sum("pesho", " ", "ivanov"));
    customLog("------------------- example 4");
    // function properties
    var properties =
        sum.length + "\n" +
        sum.name + "\n" +
        sum.prototype + "\n" +
        sum.caller;

    customLog(properties);
    customLog("------------------- example 5");
    // function evaluate
    (function() { /* ... */ });
    var printMsg = (msg) => customLog(`Message: ${msg}`);
    printMsg("hello");

    customLog("------------------- example 6");
    // function constructor
    var func = new Function("age", "customLog(age)");
    func(22);

    customLog("------------------- example 7");
    // function methods
    var methods =
        sum.toString() + "\n" +
        sum.call(null, 3, 6, 7, 8) + "\n" +
        sum.apply(null, [5, 65, 22]);
    // vmesto null moje da se podade drug context
    customLog(methods);

    function sumNew() {
        var args = [].slice.call(arguments);
        return args.reduce((s, n) => s + n, 0);
    }
    customLog(sumNew(1, 5, 6, 3, 23));
    customLog("------------------- example 8");
    // function recursion

    function fact(f) {
        if (f === 0) {
            return 1;
        }
        return fact(f - 1) * f;
    }

    customLog(fact(12));

    customLog("------------------- example 9");
    // DOM recursion
    function traverse(element) {
        function travElem(node, spacing) {
            if (node.nodeType !== 1) {
                return;
            }

            spacing = spacing || " ";

            customLog(spacing + node.nodeName);
            [...node.childNodes].forEach(child => travElem(child, spacing + "--"));
            customLog(spacing + "/" + node.nodeName);
        }
        travElem(element, "");
    }

    traverse(document.childNodes[1]);

    customLog("------------------- example 10");
    // nested functions

    function outer() {
        var num1 = 5;
        customLog(num1);
        return function middle() {
            var num2 = 30;
            customLog(num2 + num1);
            return function inner() {
                return customLog('Makes sence?');
            }
        }
    }

    var func = outer;
    func = func();
    func = func();
    func = func();

    customLog("------------------- example 11");
    // Immediately-Invoked Function Expression (IIFE)

    (function iife1() {
        customLog("iife1");
    })(); // option 1

    (function iife2() {
        customLog("iife2");
    }()); // option 2 - best option

    var iife3 = function() {
        customLog("iife3")
    }(); // option 3

    ! function() {
        customLog("iife4")
    }(); // option 4

    true && function() {
        customLog("iife5")
    }(); // option 5

    1 + function() {
        customLog("iife6")
    }(); // option 6

    customLog("------------------- example 12");
    // Immediately-Invoked Function Expression (IIFE)

    var getNextId = (function() {
        var lastId = 0;
        return function() {
            return lastId += 1;
        }
    })();

    customLog(getNextId());
    customLog(getNextId());
    customLog(getNextId());
    customLog(getNextId());

    customLog("------------------- example 13");
    // module

    var generator = (function() {
        var lastId = 0;

        function getCurrentId() {
            return lastId;
        }

        function getNextId() {
            return lastId += 1;
        }

        return {
            curr: getCurrentId,
            next: getNextId
        }
    })();

    customLog(generator.next());
    customLog(generator.curr());
    customLog(generator.next());
    customLog(generator.curr());

}());