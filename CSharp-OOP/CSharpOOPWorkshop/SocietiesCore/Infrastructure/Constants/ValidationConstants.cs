namespace SocietiesCore.Infrastructure.Constants
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ValidationConstants
    {
        public const int MinSizePortionInGrams = 0;
        public const int MaxSizePortionInGrams = 5000;

        public const int VitalityLevelMaxValue = 100;
        public const int VitalityLevelMinValue = 0;

        public const int StarvationLevelMaxValue = 100;
        public const int StarvationLevelMinValue = 0;

        public const int ThurstLevelMaxValue = 100;
        public const int ThurstLevelMinValue = 0;

        public const decimal MoneyInEuroMaxValue = 999999;
        public const decimal MoneyInEuroMinValue = 0;
    }
}
