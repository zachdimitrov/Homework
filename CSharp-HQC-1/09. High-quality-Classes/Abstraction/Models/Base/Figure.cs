using System;
using Abstraction.Contracts;

namespace Abstraction.Models.Base
{
    public abstract class Figure : IFigure
    {
        protected Figure()
        {
        }

        public abstract double CalculatePerimeter();

        public abstract double CalculateSurface();
    }
}
