﻿namespace AcademyRPG.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Giant : Fighter, IFighter, IControllable, IWorldObject, IGatherer
    {
        private bool hasStone;

        public Giant(string name, Point position)
            : base(name, position, 0, 150, 80, 200)
        {
            this.hasStone = false;
        }
        public override int GetTargetIndex(List<WorldObject> availableTargets)
        {
            var target = availableTargets
                .FirstOrDefault(x => x.Owner != 0);
            return availableTargets.IndexOf(target);
        }

        public bool TryGather(IResource resource)
        {
            bool canGather = false;
            if (resource.Type == ResourceType.Stone)
            {
                canGather = true;
                if (!hasStone)
                {

                    this.hasStone = true;
                    base.AttackPoints += 100;
                }
            }

            return canGather;
        }
    }
}
