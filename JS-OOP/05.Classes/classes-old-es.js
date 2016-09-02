"use strict";

var _typeof = typeof Symbol === "function" && typeof Symbol.iterator === "symbol" ? function (obj) { return typeof obj; } : function (obj) { return obj && typeof Symbol === "function" && obj.constructor === Symbol ? "symbol" : typeof obj; };

var _createClass = function () { function defineProperties(target, props) { for (var i = 0; i < props.length; i++) { var descriptor = props[i]; descriptor.enumerable = descriptor.enumerable || false; descriptor.configurable = true; if ("value" in descriptor) descriptor.writable = true; Object.defineProperty(target, descriptor.key, descriptor); } } return function (Constructor, protoProps, staticProps) { if (protoProps) defineProperties(Constructor.prototype, protoProps); if (staticProps) defineProperties(Constructor, staticProps); return Constructor; }; }();

function _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError("Cannot call a class as a function"); } }

// ------ simple class example -------
var Person = function () {
    // ------- constructor --------
    function Person(fname, lname, height) {
        _classCallCheck(this, Person);

        fname = fname || "unknown";
        lname = lname || "unknown";
        this._fname = fname;
        this._lname = lname;
        if (height < 0) {
            throw "Not possible?!";
        }
        this._height = height;
        this._age = 0;
    }
    // ------- methods -------


    _createClass(Person, [{
        key: "nextYear",
        value: function nextYear() {
            this._age += 1;
        }
    }, {
        key: "sayHello",
        value: function sayHello() {
            return this._fname + " " + this._lname + " " + this._age;
        }
        // ------ getter -------

    }, {
        key: "height",
        get: function get() {
            return this._height;
        },
        set: function set(value) {
            if (value > this._height + 0.01) {
                this._height += 0.01;
            }
        }
    }, {
        key: "fullName",
        get: function get() {
            return this.fname + " " + this.lname;
        },
        set: function set(value) {
            throw "Rangelee, ne moje da si smenqsh imeto!";
        }
    }]);

    return Person;
}();

var pesho = new Person("Pesho", "Ivanov", 1.6);
var gosho = new Person("Gosho", "", 1.8);

pesho._fname = "Peshko";

console.log(typeof Person === "undefined" ? "undefined" : _typeof(Person)); // logs 'function'
console.log(typeof pesho === "undefined" ? "undefined" : _typeof(pesho)); // logs 'object'

gosho.height = 5;
gosho.height = 4;
gosho.nextYear();
gosho.nextYear();
gosho.nextYear();
console.log(gosho.sayHello());
console.log(gosho.height);

console.log(pesho);
console.log(gosho);

//# sourceMappingURL=classes-old-es.js.map