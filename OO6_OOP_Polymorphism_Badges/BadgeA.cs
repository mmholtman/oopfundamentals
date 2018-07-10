using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO6_OOP_Polymorphism_Badges
{
    public class BadgeA : Badge
    {
        public BadgeA(int level)
        {
            Level = level;
        }
        public int Level { get; set; }
        public override bool AllowAccess(int level)
        {
            if(level == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
