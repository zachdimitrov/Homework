namespace AcademyEcosystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Wolf : Animal, ICarnivore
    {
        private const int DefWolfSize = 4;
        public Wolf(string name, Point position) : base(name, position, DefWolfSize)
        {

        }

        public int TryEatAnimal(Animal animal)
        {
            int meatEatten = 0;
            if (animal != null && (animal.Size <= this.Size || animal.State == AnimalState.Sleeping))
            {
                meatEatten = animal.GetMeatFromKillQuantity();
            }
            return meatEatten;
        }
    }
}
