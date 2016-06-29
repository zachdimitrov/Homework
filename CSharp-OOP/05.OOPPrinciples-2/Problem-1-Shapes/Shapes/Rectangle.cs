namespace Problem_1_Shapes.Shapes
{
    class Rectangle : Shape
    {
        public Rectangle()
        {
        }

        public Rectangle(decimal Width, decimal Height)
        {
            this.Width = Width;
            this.Height = Height;
        }

        public override decimal CalculateSurface()
        {
            decimal surface = this.Height * this.Width;
            return surface;
        }
    }
}
