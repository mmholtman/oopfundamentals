using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO6_OOP_Polymorphism_Badges
{
    class BadgeC : Badge
    {
        
        public int Level { get; set; }
        public BadgeC(int level)
        {
            Level = level;
        }
        public override bool AllowAccess(int level)
        {
            if(level == 3)
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
