namespace SocietiesCore.Contracts
{
    using System;
    using System.Collections.Generic;

    public interface IFood : IConsumable
    {
        int PortionSizeGrams { get; set; }
    }
}