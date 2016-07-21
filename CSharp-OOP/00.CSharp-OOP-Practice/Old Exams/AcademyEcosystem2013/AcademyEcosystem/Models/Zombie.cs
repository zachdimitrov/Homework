namespace AcademyEcosystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Zombie : Animal
    {
        private const int DefZombieSize = 0;
        public Zombie(string name, Point position) : base(name, position, DefZombieSize)
        {

        }

        public override int GetMeatFromKillQuantity()
        {
            return 10;
        }
    }
}
