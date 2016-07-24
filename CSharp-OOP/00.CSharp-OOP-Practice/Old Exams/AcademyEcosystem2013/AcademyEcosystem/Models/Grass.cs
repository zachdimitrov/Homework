namespace AcademyEcosystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Grass : Plant
    {
        private const int DefGrassSize = 2;
        public Grass(Point position) : base(position, DefGrassSize)
        {
        }

        public override void Update(int time)
        {
            if (base.IsAlive)
            {
                base.Size += time;
            }
        }
    }
}
