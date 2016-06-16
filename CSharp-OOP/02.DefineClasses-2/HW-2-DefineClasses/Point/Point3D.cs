namespace DefineClasses2
{

    /// <summary>
    /// a structure to store a simple 3D point
    /// </summary>

    public struct Point3D // Problem 1. structure
    {
        private static Point3D origin;  // Problem 2. static read-only field
        public double X { get; set; }  // fields
        public double Y { get; set; }
        public double Z { get; set; }
        // constructor

        public Point3D(double X = 0, double Y = 0, double Z = 0) : this()
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }
        // static property
        public static Point3D Origin
        {
            get
            {
                return origin;
            }
            set
            {
                origin.X = 0;
                origin.Y = 0;
                origin.Z = 0;
            }
        }
        // override method
        public override string ToString()
        {
            return string.Format("({0}, {1}, {2})", X, Y, Z);
        }
    }
}
