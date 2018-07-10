using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO6_OOP_Polymorphism_Exercise2
{
    public abstract class Employee
    {
        public abstract void FlashBadge();
        public abstract Employee ChangeLocation(Location location);

    }

    public enum Location
    {
        Enter,
        Leave,
        Elevator
    }
}
