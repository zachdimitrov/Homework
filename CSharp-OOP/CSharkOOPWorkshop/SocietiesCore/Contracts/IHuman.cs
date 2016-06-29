namespace SocietiesCore.Contracts
{
    using System;
    using System.Collections.Generic;
    using Infrastructure.Enumerations;
    using Infrastructure.Enumerations.Human;
    using Models.Common;

    public interface IHuman
    {
        int Id { get; }
        string Name { get; }
        int Age { get; }
        GenderType Gender { get;}
        ReligionType Religion { get; }
        RaceType Race { get; }
        HairType HairColor { get; }
        EyesColorType EyesColor { get; }
        FaceType FaceShape { get; }
        decimal MoneyInEuro { get; }
        int VitalityLevel { get; }
        int StarvationLevel { get; }
        int ThurstLevel { get; }

        void Eat(ICollection<IFood> food);
        void Drink(ICollection<IBeverage> beverage);
        void Work(int hours);
        void Sleep(int hours);
        void Rest(int minutes);
        decimal Pay(decimal amountPaid);
    }
}