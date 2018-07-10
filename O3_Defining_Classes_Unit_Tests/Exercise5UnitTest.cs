using System;
using C2_Reference_Types;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _04_OOP_Encapsulation_Exercise_1;

namespace O3_Defining_Classes_Unit_Tests
{
    [TestClass]
    public class Exercise5UnitTest
    {
        private EncapCustomer _customer;

        [TestInitialize]
        public void Arrange()
        {
            _customer = new EncapCustomer("Max", "Holtman", 30);
        }

        [TestMethod]
        public void GetAndSetFirstName_ShouldSucceed()
        {
            //Arrange
            //Act
            string actual = _customer.FirstName;
            string expected = "Max";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "Unusable string")]
        public void GetAndSetFirstName_CatchException()
        {
            //Arrange
            EncapCustomer customer = new EncapCustomer(null, "Holtman", 40);
        }


        [TestMethod]
        public void GetAndSetLastName_ShouldSucceed()
        {
            //Arrange

            //Act
            string actual = _customer.LastName;
            string expected = "Holtman";
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetAndSetAge_ShouldSucceed()
        {
            //Arrange

            //Act
            int actual = _customer.Age;
            int expected = 30;
            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
