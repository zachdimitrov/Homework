namespace Problem_1_Shapes
{
    using Problem_1_Shapes.Shapes;
    using System.Collections.Generic;
    using System.Text;

    class SahpesTestStart
    {
        static void Main()
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Triangle(12.5m, 23.7m));
            shapes.Add(new Rectangle(35.1m, 162.3m));
            shapes.Add(new Square(12223.7m));

            var result = new StringBuilder();
            foreach (var item in shapes)
            {
                decimal surface = item.CalculateSurface();
                result.AppendLine($"Surface of current {item.GetType().Name} is: {surface}");
            }
            System.Console.WriteLine(result.ToString());
        }
    }
}
