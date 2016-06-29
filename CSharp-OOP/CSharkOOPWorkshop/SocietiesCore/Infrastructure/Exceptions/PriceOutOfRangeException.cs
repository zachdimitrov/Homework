namespace SocietiesCore.Infrastructure.Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PriceOutOfRangeException : ArgumentOutOfRangeException
    {
        public PriceOutOfRangeException(string message, decimal PriceValue) : base(message)
        {
            this.PriceValue = PriceValue;
        }

        public decimal PriceValue { get; set; }
    }
}
