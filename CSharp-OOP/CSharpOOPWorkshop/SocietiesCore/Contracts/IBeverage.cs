namespace SocietiesCore.Contracts
{
    using Models.Common.Abstract;
    using System;
    using System.Collections.Generic;

    public interface IBeverage
    {
        int SizeOfPortionInMl { get; set; }
    }
}