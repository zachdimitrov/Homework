namespace DefineClasses2.Point
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// create path using 3D points
    /// </summary>

    public class Path  // Problem 4. path
    {
        private List<Point3D> points;

        public Path()
        {
            this.points = new List<Point3D>();
        }

        public void AddPoint(double x, double y, double z)
        {
            foreach (var point in points)
            {
                if (point.X == x && point.Y == y && point.Z == z)
                {
                    throw new ArgumentException("This point is already listed in the path");
                }
            }
            Point3D p = new Point3D(x, y, z);
            points.Add(p);
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < points.Count; i++)
            {
                str = str.AppendLine(String.Format(points[i].ToString()));
            }
            return str.ToString();
        }
    }
}
