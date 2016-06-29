namespace SocietiesCore.Models.Common
{
    using Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RestaurantOrder : IRestaurantOrder
    {
        public ICollection<IBeverage> Beverage { get; set; }

        public ICollection<IFood> Foods { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
