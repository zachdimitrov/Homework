namespace AcademyEcosystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Boar : Animal, ICarnivore, IHerbivore
    {
        private const int DefBoarSize = 4;
        private int biteSize;

        public Boar(string name, Point position) : base(name, position, DefBoarSize)
        {
            this.biteSize = 2;
        }

        public int EatPlant(Plant plant)
        {
            int quantityEaten = 0;
            if (plant != null)
            {
                quantityEaten = plant.GetEatenQuantity(this.biteSize);
                base.Size++;
            }
            return quantityEaten;
        }

        public int TryEatAnimal(Animal animal)
        {
            int meatEatten = 0;
            if (animal != null && animal.Size <= this.Size)
            {
                meatEatten = animal.GetMeatFromKillQuantity();
            }
            return meatEatten;
        }
    }
}
