var PrintNameMixin = function(Base) {
    return class extends Base {
        printName() {
            console.log(this._name);
        }
    };
};

let ValidationMixin = function(Base) {
    return class extends Base {
        _ValdateName(name) {
            if (typeof name !== 'string') {
                throw 'Name must be a string!'
            }
            if (name.length === 0) {
                throw 'Name must not be empty!';
            }
        }
    };
};

class Person extends PrintNameMixin(ValidationMixin(Object)) {
    constructor(name, age) {
        super();
        this._ValdateName(name);
        this._name = name;
        this._age = age;
    }
}

class Traktor extends PrintNameMixin(Object) {
    constructor(name) {
        super();
        this._name = name;
    }
}

let p = new Person('Ivan');
p.printName();

let t = new Traktor('Giant');
t.printName();