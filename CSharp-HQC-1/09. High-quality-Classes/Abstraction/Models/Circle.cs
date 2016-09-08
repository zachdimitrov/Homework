using System;
using Abstraction.Models.Base;

namespace Abstraction.Models
{
    public class Circle : Figure
    {
        private double radius;

        public Circle(double radius)
            : base()
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get
            {
                return this.radius;
            }
            set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentException("Radius must be a positive value!");
                }

                this.radius = value;
            }
        }

        /// <summary>
        /// Calculates this circle perimeter.
        /// </summary>
        /// <returns>Perimeter value as double number.</returns>
        public override double CalculatePerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;

            return perimeter;
        }

        /// <summary>
        /// Calculate this circle surface.
        /// </summary>
        /// <returns>Surface value as double number.</returns>
        public override double CalculateSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;

            return surface;
        }
    }
}