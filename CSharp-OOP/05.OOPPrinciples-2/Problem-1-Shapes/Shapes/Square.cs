namespace Problem_1_Shapes.Shapes
{
    class Square : Rectangle
    {
        public Square()
        {
        }

        public Square(decimal Size)
        {
            this.Width = Size;
            this.Height = Size;
        }
    }
}
