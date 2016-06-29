namespace Problem_1_Shapes
{
    public abstract class Shape
    {
        private decimal width;
        private decimal height;

        public decimal Height
        {
            get { return height; }
            set { height = value; }
        }

        public decimal Width
        {
            get { return width; }
            set { width = value; }
        }

        public abstract decimal CalculateSurface();
    }
}
