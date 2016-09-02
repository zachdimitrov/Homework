// ------ simple class example -------
class Person {
    // ------- constructor --------
    constructor(fname, lname, height) {
            fname = fname || "unknown";
            lname = lname || "unknown";
            this._fname = fname;
            this._lname = lname;
            if (height < 0) {
                throw ("Not possible?!")
            }
            this._height = height;
            this._age = 0;
        }
        // ------- methods -------
    nextYear() {
        this._age += 1;
    }
    sayHello() {
            return (this._fname + " " + this._lname + " " + this._age);
        }
        // ------ getter and setter -------
    get height() {
        return this._height;
    }
    set height(value) {
        if (typeof value !== "number") {
            throw "New height should be a number";
        }
        if (value > this._height + 0.01) {
            this._height += 0.01;
        }
    }
    get fullName() {
        return `${this.fname} ${this.lname}`
    }
    set fullName(value) {
        throw "Rangelee, ne moje da si smenqsh imeto!";
    }
}

let pesho = new Person("Pesho", "Ivanov", 1.6);
let gosho = new Person("Gosho", "", 1.8);

pesho._fname = "Peshko";

console.log(typeof Person); // logs 'function'
console.log(typeof pesho); // logs 'object'

gosho.height = 5;
gosho.height = 4;
gosho.nextYear();
gosho.nextYear();
gosho.nextYear();
console.log(gosho.sayHello());
console.log(gosho.height)

console.log(pesho);
console.log(gosho);