using System;
using _O6_OOP_Polymorphism_Demo_4;
using _O6_OOP_Polymorphism_Demo_4.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace O3_Defining_Classes_Unit_Tests
{
    [TestClass]
    public class Exercise10UnitTest
    {
        private Employee _employee;
        [TestMethod]
        public void Employee_ElevatorSwipe_ShouldPrintToConsole()
        {
            _employee = new Employee(new ElevatorService());
            _employee.SwipeCard();
        }
    }
}
