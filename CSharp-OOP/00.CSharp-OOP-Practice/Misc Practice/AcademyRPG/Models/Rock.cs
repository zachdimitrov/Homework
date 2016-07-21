namespace AcademyRPG.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Rock : StaticObject, IResource
    {
        public Rock(int hitPoints, Point position) : base(position, 0)
        {
            this.Type = ResourceType.Stone;
            base.HitPoints = hitPoints;
        }

        public int Quantity
        {
            get
            {
                return base.HitPoints / 2;
            }
        }

        public ResourceType Type { get; private set; }
    }
}
