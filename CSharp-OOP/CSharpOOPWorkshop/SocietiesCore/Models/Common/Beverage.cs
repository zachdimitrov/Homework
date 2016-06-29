namespace SocietiesCore.Models.Common
{
    using Abstract;
    using Contracts;
    using Infrastructure.Enumerations.Common;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Beverage : Consumable, IBeverage
    {
        private int sizeOfPortionInMl;

        public int SizeOfPortionInMl
        {
            get { return this.sizeOfPortionInMl; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Beverage cannot be empty!");
                }
                this.sizeOfPortionInMl = value;
            }
        }
    }
}
