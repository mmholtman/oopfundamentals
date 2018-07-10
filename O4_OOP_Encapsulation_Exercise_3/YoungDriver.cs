using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O4_OOP_Encapsulation_Exercise_3
{
    public class YoungDriver
    {
        private const double BASE_CHARGE = 120;

        public double Cost { get; private set; }

        public int Age { get; set; }

        public YoungDriver()
        {
        }

        public double GetCost()
        {
            return CalculateCost();
        }

        private double CalculateCost()
        {
            var age = Age;
            if (age >= 16 && age <= 19)
            {
                Cost = BASE_CHARGE * 1.9;
            }
            else if (age >= 20 && age <= 22)
            {
                Cost = BASE_CHARGE * 1.6;
            }
            else if (age >= 23 && age <= 25)
            {
                Cost = BASE_CHARGE * 1.5;
            }
            else
            {
                throw new Exception("The age is outside the specified range.");
            }
            return Cost;
        }

    }
}
