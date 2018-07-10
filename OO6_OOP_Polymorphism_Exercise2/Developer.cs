using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO6_OOP_Polymorphism_Exercise2
{
    class Developer : Employee
    {

        public Enum Location { get; set; }

        public override Employee ChangeLocation(Location location)
        {
            throw new NotImplementedException();
        }

        public override void FlashBadge()
        {
            throw new NotImplementedException();
        }
    }
}
