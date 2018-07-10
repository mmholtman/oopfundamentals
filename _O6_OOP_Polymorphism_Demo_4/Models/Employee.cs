using _O6_OOP_Polymorphism_Demo_4.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _O6_OOP_Polymorphism_Demo_4
{
    public class Employee
    {
        private ISwipeable _swipeable;

        public Employee(ISwipeable swipeable)
        {
            _swipeable = swipeable;
        }

        public void SwipeCard()
        {
            Console.WriteLine("Swiping card now");
            _swipeable.Swipe();
        }

        public void AcceptCard()
        {
            Console.WriteLine("Accepting card now");
            _swipeable.Accept();
        }
    }
}
