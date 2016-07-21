namespace AcademyEcosystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Lion : Animal, ICarnivore
    {
        private const int DefLionSize = 6;

        public Lion(string name, Point position) : base(name, position, DefLionSize)
        {

        }

        public int TryEatAnimal(Animal animal)
        {
            int meatEaten = 0;
            if (animal != null && animal.Size <- this.Size * 2 )
            {
                meatEaten = animal.GetMeatFromKillQuantity();
                base.Size++;
            }
            return meatEaten;
        }
    }
}
