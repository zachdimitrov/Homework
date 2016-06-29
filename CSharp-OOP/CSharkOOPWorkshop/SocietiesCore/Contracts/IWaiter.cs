namespace SocietiesCore.Contracts
{
    using Models.Common;
    using System;
    using System.Collections.Generic;

    public interface IWaiter
    {
        decimal Tip { get; set; }
        void GetOrder(IRestaurantOrder order, IHuman client);
        void ServeOrder(IHuman client);
        void RequestPayment(IHuman client);
    }
}