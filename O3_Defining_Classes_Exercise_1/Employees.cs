using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O3_Defining_Classes_Exercise_1
{
    public class Employees
    {
        public Guid EmployeeId { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public int YearsAtKomodo { get; set; }

        public Employees(Guid id, string lastName, int age, int years)
        {
            EmployeeId = id;
            LastName = lastName;
            Age = age;
            YearsAtKomodo = years;
        }
    }
}
