class Point {
    constructor(x, y) {
        this._x = +x;
        this._y = +y;
    }

    rotate90() {
        let z = this._y;
        this._y = this._x;
        this._x = -z;
    }

    print() {
        console.log(`(${this._x}, ${this._y})`);
    }

    distanceTo(p) {
        const x = this._x - p._x;
        const y = this._y - p._y;
        return Math.sqrt(x * x + y * y);
    }

    static centerPoint() {
        return new Point(0, 0);
    }

    static distance(p1, p2) {
        return p1.distanceTo(p2);
    }
}

let p = new Point(3, -2);
p.print();
p.rotate90();
p.print();
Point.centerPoint().print();
console.log(Point.distance(p, Point.centerPoint()));
console.log(Point.distance(p, new Point(55, 77)));