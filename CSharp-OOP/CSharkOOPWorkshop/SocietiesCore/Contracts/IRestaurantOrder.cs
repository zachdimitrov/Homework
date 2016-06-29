namespace SocietiesCore.Contracts
{
    using System;
    using System.Collections.Generic;

    public interface IRestaurantOrder
    {
        ICollection<IFood> Foods { get; set; }
        ICollection<IBeverage> Beverage { get; set; }

        decimal TotalPrice { get; set; }
    }
}