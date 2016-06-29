namespace SocietiesCore.Models.Common.Abstract
{
    using Contracts;
    using Infrastructure.Enumerations.Common;
    using Infrastructure.Exceptions;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Consumable : IConsumable
    {
        private decimal price;

        public BeverageType Type { get; set; }
        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new PriceOutOfRangeException("Price cannot be negative!", value);
                }
                else if(value > decimal.MaxValue)
                {
                    throw new PriceOutOfRangeException("Price is too large!", value);
                }
                this.price = value;
            }
        }
    }
}
