namespace Problem_1_Shapes.Shapes
{
    class Triangle : Shape
    {
        public Triangle()
        {
        }

        public Triangle(decimal Base, decimal Height)
        {
            this.Width = Base;
            this.Height = Height;
        }
        public override decimal CalculateSurface()
        {
            decimal surface = (this.Height * this.Width) / 2;
            return surface;
        }
    }
}
