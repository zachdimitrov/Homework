namespace SocietiesCore.Contracts
{
    using Infrastructure.Enumerations.Common;
    using System;
    using System.Collections.Generic;

    public interface IConsumable
    {
        BeverageType Type { get; set; }
        decimal Price { get; set; }
    }
}