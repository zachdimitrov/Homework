namespace SocietiesCore.Models.Common
{
    using Abstract;
    using Contracts;
    using Infrastructure.Enumerations.Common;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Food : Consumable, IFood
    {
        public int PortionSizeGrams { get; set; }
    }
}
