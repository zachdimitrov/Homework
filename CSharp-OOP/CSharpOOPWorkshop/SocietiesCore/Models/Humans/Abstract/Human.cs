namespace SocietiesCore.Models.Humans.Abstract
{
    using Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Infrastructure.Enumerations.Human;
    using Common;
    using Infrastructure.Utilities;
    using System.Text;
    using Infrastructure.Constants;

    public abstract class Human : IHuman
    {
        private readonly string name;
        private readonly int age;
        private readonly HairType hairColor;
        private readonly EyesColorType eyesColor;
        private readonly FaceType face;
        private readonly ReligionType religion;
        private readonly GenderType gender;
        private readonly RaceType race;
        private int vitalityLevel;
        private int id;
        private int thurstLevel;
        private int starvationLevel;
        private decimal moneyInEuro;

        private Human()
        {
            this.vitalityLevel = ValidationConstants.VitalityLevelMaxValue;
            this.starvationLevel = ValidationConstants.StarvationLevelMaxValue;
            this.thurstLevel = ValidationConstants.ThurstLevelMaxValue;
            this.moneyInEuro = ValidationConstants.MoneyInEuroMaxValue;
        }

        public Human(
            string name,
            int age, 
            HairType hairColor, 
            EyesColorType eyesColor,
            FaceType face,
            RaceType race,
            GenderType gender,
            ReligionType religion ) : this()
        {
            this.id = DataGenerator.GenerateUniqueId();
            this.name = name;
            this.age = age;
            this.hairColor = hairColor;
            this.face = face;
            this.gender = gender;
            this.race = race;
            this.eyesColor = eyesColor;
            this.religion = religion;
        }

        public int Age
        {
            get { return this.age; }
        }
        public EyesColorType EyesColor
        {
            get { return this.eyesColor; }
        }
        public FaceType FaceShape
        {
            get { return this.face; }
        }
        public GenderType Gender
        {
            get { return this.gender; }
        }
        public HairType HairColor
        {
            get { return this.hairColor; }
        }
        public int Id
        {
            get { return this.id; }
        }
        public decimal MoneyInEuro
        {
            get { return this.moneyInEuro; }
        }
        public string Name { get; }
        public RaceType Race { get; }
        public ReligionType Religion { get; }
        public int StarvationLevel { get; }
        public int ThurstLevel { get; }
        public int VitalityLevel { get; }

        public void Drink(ICollection<IBeverage> beverage)
        {
            throw new NotImplementedException();
        }
        public void Eat(ICollection<IFood> food)
        {
            throw new NotImplementedException();
        }
        public void Rest(int minutes)
        {
            throw new NotImplementedException();
        }
        public void Sleep(int hours)
        {
            throw new NotImplementedException();
        }
        public void Work(int hours)
        {
            throw new NotImplementedException();
        }
        public virtual decimal Pay(decimal amountPaid)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            var builder = new StringBuilder(500);

            builder.AppendLine(new string('=', GlobalConstants.DelimiterCount));
            builder.AppendLine($"Name: {this.name}");
            builder.AppendLine($"Age: {this.age}");
            builder.AppendLine($"ID: {this.Id}");
            builder.AppendLine($"Hair: {this.hairColor}");
            builder.AppendLine($"Gender: {this.gender}");
            builder.AppendLine($"Religion: {this.religion}");
            builder.AppendLine($"Face: {this.face}");
            builder.AppendLine($"Money: ${this.moneyInEuro}");
            builder.AppendLine($"Vitality: {this.vitalityLevel}/{ValidationConstants.VitalityLevelMaxValue}");
            builder.AppendLine($"Starvation: {this.starvationLevel}/{ValidationConstants.StarvationLevelMaxValue}");
            builder.AppendLine($"Starvation: {this.thurstLevel}/{ValidationConstants.ThurstLevelMaxValue}");
            builder.AppendLine(new string('=', 20));

            return builder.ToString();
        }

        public override int GetHashCode()
        {
            return this.id.GetHashCode();
        }
    }
}
