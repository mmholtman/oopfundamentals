using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O6_OOP_Polymorphism_Exercise_1
{
    public class Instructor : IEmployee
    {
        public Guid EmployeeId { get; set; }
        public DateTime EmploymentStartDate { get; set; }
        public string[] CoursesCurrentlyTeaching { get; set; }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void GetEmployee()
        {
            throw new NotImplementedException();
        }

        public void CreateEmployee()
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee()
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployee()
        {
            throw new NotImplementedException();
        }

        public void ListAllEmployees()
        {
            throw new NotImplementedException();
        }
    }
}
