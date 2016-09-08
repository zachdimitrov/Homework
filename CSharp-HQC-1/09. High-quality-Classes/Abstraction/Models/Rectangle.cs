using System;
using Abstraction.Models.Base;

namespace Abstraction
{
    public class Rectangle : Figure
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
            : base()
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentException("Width must be a positive value!");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height must be a positive value!");
                }
                this.height = value;
            }
        }

        /// <summary>
        /// Calculate the rectangle perimeter by its width and height.
        /// </summary>
        /// <returns>Perimeter value as double number.</returns>
        public override double CalculatePerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);

            return perimeter;
        }

        /// <summary>
        /// Calculate the rectangle surface by its width and height.
        /// </summary>
        /// <returns>Surface value as double number.</returns>
        public override double CalculateSurface()
        {
            double surface = this.Width * this.Height;

            return surface;
        }
    }
}
