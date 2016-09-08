using System;
using CohesionAndCoupling.Contracts;
using CohesionAndCoupling.Utilities;

namespace CohesionAndCoupling.Models
{
    /// <summary>
    /// Create simple 3D prism instance
    /// </summary>
    public class Prism : IPrism
    {
        private double width;
        private double height;
        private double depth;

        public Prism()
        {
        }

        public Prism(double width, double height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }

        public double Width
        {
            get { return width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width should be positive number!");
                }

                width = value;
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Height should be positive number!");
                }

                height = value;
            }
        }

        public double Depth
        {
            get { return depth; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Depth should be positive number!");
                }

                depth = value;
            }
        }

        /// <summary>
        /// Calculate the long diagonal of the prism (eqial in all directions)
        /// </summary>
        /// <returns>Diagonal length</returns>
        public double CalculateDiagonal3D()
        {
            double LongDiagonal = CalcUtils.CalcDistance3D(0, 0, 0, this.Width, this.Height, this.Depth);
            return LongDiagonal;
        }

        /// <summary>
        /// Calculate any of the three short diagonals (XY, YZ, XZ)
        /// </summary>
        /// <param name="diagonal">Enter string in the format "XY", "YZ", "XZ", case insensitive</param>
        /// <returns>Required diagonal length</returns>
        public double CalculateDiagonal2D(string diagonal)
        {
            string command = diagonal.ToLower();

            if (command == null)
            {
                throw new ArgumentNullException("Command cannot be null!");
            }

            bool correctCommand = 
                command == "xy" || command == "yx" ||
                command == "xz" || command == "zx" ||
                command == "yz" || command == "zy";

            if (!correctCommand)
            {
                throw new ArgumentOutOfRangeException("Command is not the correct format (xy, yz, xz)!");
            }

            double shortDiagonal = 0;

            if (command == "xy" || command == "yx")
            {
                shortDiagonal = CalcUtils.CalcDistance2D(0, 0, this.Width, this.Height);
            }
            else if(command == "xz" || command == "zx")
            {
                shortDiagonal = CalcUtils.CalcDistance2D(0, 0, this.Width, this.Depth);
            }
            else if(command == "zy" || command == "yz")
            {
                shortDiagonal = CalcUtils.CalcDistance2D(0, 0, this.Height, this.Depth);
            }

            return shortDiagonal;
        }

        /// <summary>
        /// Calculate volume of the prism
        /// </summary>
        /// <returns>Volume in cubical units</returns>
        public double CalculateVolume()
        {
            double volume = this.Width * this.Height * this.Depth;
            return volume;
        }
    }
}
