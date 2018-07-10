using System;

namespace O6_OOP_Polymorphism_Exercise_1
{
    public class Contractor : IEmployee
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public Guid EmployeeId { get; set; }
        public DateTime EmploymentStartDate { get; set; }

        public TimeSpan ContractLength { get; set; }

        public void GetEmployee()
        {
            throw new System.NotImplementedException();
        }

        public void CreateEmployee()
        {
            throw new System.NotImplementedException();
        }

        public void DeleteEmployee()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateEmployee()
        {
            throw new System.NotImplementedException();
        }

        public void ListAllEmployees()
        {
            throw new System.NotImplementedException();
        }
    }
}