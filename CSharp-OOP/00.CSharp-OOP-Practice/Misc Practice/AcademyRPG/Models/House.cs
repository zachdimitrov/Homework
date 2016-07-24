namespace AcademyRPG.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class House : StaticObject
    {
        public House(Point position, int owner) : base(position, owner)
        {
            base.HitPoints = 500;
        }
    }
}
