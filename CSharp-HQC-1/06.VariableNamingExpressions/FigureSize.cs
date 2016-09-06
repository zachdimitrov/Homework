namespace VariablesNameExpressions
{
    using System;

    // Task 1. Class Size in C#
    public class FigureSize
    {
        public double Width;
        public double Height;

        public FigureSize(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public static FigureSize GetRotatedSize(FigureSize size, double angle)
        {
            var cosAngle = Math.Abs(Math.Cos(angle));
            var sinAngle = Math.Abs(Math.Sin(angle));

            var newWidth = cosAngle * size.Width + sinAngle * size.Height;
            var newHeight = sinAngle * size.Width + cosAngle * size.Height;

            var rotatedSize = new FigureSize(newWidth, newHeight);

            return rotatedSize;
        }
    }
}
