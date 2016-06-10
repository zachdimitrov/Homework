namespace GSMProgram
{
    using System;

    public class Display
    {
        // class for GSM displays
        private float size; // diagonal of display - 5.5 in
        private int colors; // number of colors - 256 colors

        public Display() // default constructor
        {
        }

        public Display(float size, int colors) // full constructor
        {
            this.size = size;
            this.colors = colors;
        }

        public float Size // property
        {
            get { return size; }
            set { size = value; }
        }

        public int Colors // property
        {
            get { return colors; }
            set { colors = value; }
        }

        public override string ToString()
        {
            return string.Format("{0} inch, {1} colors.", this.Size, this.Colors);
        }
    }
}
