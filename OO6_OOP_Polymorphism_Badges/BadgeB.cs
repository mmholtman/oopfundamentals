using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO6_OOP_Polymorphism_Badges
{
     class BadgeB : Badge
    {
        
        public int Level { get; set; }
        public override bool AllowAccess(int level)
        {
            if(level == 2)
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
