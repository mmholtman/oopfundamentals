using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O5_OOP_Inheritance_Exercise_1
{
    public abstract class Outing
    {
        public int NumberThatAttended { get; set; }
        public DateTime OutingDate { get; set; }
        public string Location { get; set; }
        public decimal TotalCost { get; set; }

        public Outing()
        {

        }
        public Outing(int numAttended, DateTime date, string location, decimal cost)
        {
            NumberThatAttended = numAttended;
            OutingDate = date;
            Location = location;
            TotalCost = cost;
        }
        public abstract void CalculateCostPerPerson();
    }
}
