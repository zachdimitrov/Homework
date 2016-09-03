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
            var newWidth = Math.Abs(Math.Cos(angle)) * size.Width + Math.Abs(Math.Sin(angle)) * size.Height;
            var newHeight = Math.Abs(Math.Sin(angle)) * size.Width + Math.Abs(Math.Cos(angle)) * size.Height);

            var rotatedSize = new FigureSize(newWidth, newHeight);

            return rotatedSize;
        }
    }
}
