class Mammal {
    constructor(age) {
        this._age = age;
    }

    walk() {
        console.log("I am a walking ");
    }
}

class Person extends Mammal {
    constructor(name, age) {
        super(age);
        this._name = name;
    }

    walk() {
        super.walk();
        console.log("human!");
    }

    say(text) {
        console.log(`${this._name}: ${text}`);
    }

    introduce() {
        console.log(`My name is ${this._name}.`);
    }
}

let p = new Person("Pesho", 22);
console.log(p._name);
p.say("what's up!");
p.introduce();
p.walk();