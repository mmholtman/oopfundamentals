using OO6_OOP_Polymorphism_Exercise2.LocationMessages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO6_OOP_Polymorphism_Exercise2
{
    class Claims : Employee
    {
        public Location Location { get; set; }

        public override Employee ChangeLocation(Location location)
        {
            throw new NotImplementedException();
        }

        public override void FlashBadge()
        {
            
        }

        private string GetClaimsLeaveMessage()
        {
            return "Great job today. You adjusted 52 claims. ";
        }
    }
}
