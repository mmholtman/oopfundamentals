using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO6_OOP_Polymorphism_Badges
{
    public abstract class Badge : IBadge
    {
        public List<Badge> Badges = new List<Badge>();

        List<Badge> IBadge.Badges { get; set; }

        public abstract bool AllowAccess(int level);
        public void AddToBadges(Badge badge)
        {
            Badges.Add(badge);
        }

    }
}
