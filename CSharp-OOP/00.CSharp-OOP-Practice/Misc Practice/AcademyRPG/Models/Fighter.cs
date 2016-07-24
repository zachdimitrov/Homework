namespace AcademyRPG.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Fighter : Character, IFighter, IControllable, IWorldObject
    {
        public Fighter(string name, Point position, int owner, int attackPoints, int hitPoints, int defencePoints) : base(name, position, owner)
        {
            this.HitPoints = hitPoints;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defencePoints;
        }

        public int AttackPoints { get; protected set; }

        public int DefensePoints { get; private set; }

        public abstract int GetTargetIndex(List<WorldObject> availableTargets);
    }
}
