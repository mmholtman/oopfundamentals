using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using O3_Defining_Classes_Exercise_1;

namespace O3_Defining_Classes_Unit_Tests
{

    [TestClass]
    public class Exercise1UnitTest
    {
        private Employees _employee;
        [TestInitialize]
        public void Arrange()
        {
            _employee = new Employees(new Guid("62fa647c-ad54-4bcc-a860-e5a2664b019d"), "Holtman", 22, 3);
        }

        [TestMethod]
        public void CreateEmployee_ShouldSucceed()
        {
            //Arrange
            Arrange();

            //Act
            var actualName = _employee.LastName;
            var actualGuid = _employee.EmployeeId;
            var expected = "Holtman";
            Guid expectedGuid = new Guid("62fa647c-ad54-4bcc-a860-e5a2664b019d");

            //Assert
            Assert.AreEqual(expected, actualName);
            Assert.AreEqual(expectedGuid, actualGuid);
        }
    }
}
