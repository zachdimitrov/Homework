namespace DefineClasses2.Point
{
    using System;

    /// <summary>
    /// calculate distance between points in 3D space
    /// </summary>

    public static class Calculate // Problem 3. Calculate distance between 2 points
    {
        public static double Distance(Point3D A, Point3D B)
        {
            double dist = Math.Sqrt(Convert.ToDouble((A.X - B.X) * (A.X - B.X) + (A.Y - B.Y) * (A.Y - B.Y) + (A.Z - B.Z) * (A.Z - B.Z)));
            return dist;
        }
    }
}
