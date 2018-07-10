using System;

namespace O6_OOP_Polymorphism_Exercise_1
{
    public interface IEmployee
    {
        string LastName { get; set; }
        string FirstName { get; set; }
        Guid EmployeeId { get; set; }
        DateTime EmploymentStartDate { get; set; }
        void GetEmployee();
        void CreateEmployee();
        void DeleteEmployee();
        void UpdateEmployee();
        void ListAllEmployees();
    }
}