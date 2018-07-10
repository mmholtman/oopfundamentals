using System;
using System.Collections.Generic;
using System.Runtime.Remoting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _03_Defining_Classes_Exercise_3;


namespace O3_Defining_Classes_Unit_Tests
{
    [TestClass]
    public class Exercise3UnitTest
    {
        private Customer _customer;
        private CustomerRepo _customerRepo;

        [TestInitialize]
        public void Arrange()
        {
            _customer = new Customer(new Guid(), "Bon Jovi", 50, 20);
            _customerRepo = new CustomerRepo();
        }

        [TestMethod]
        public void CustomerEmailTest_ReturnString()
        {
            //Act
            var actual = _customerRepo.SendThankYouNote(_customer);

            var expected = "You're a gold member";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddCustomerToList_ShouldSucceed()
        {
            //Act
            var actualList = _customerRepo.AddCustomerToList(_customer);
            var expectedList = GenerateExpectedCustomerList();

            //Assert
            CollectionAssert.AreEqual(expectedList, actualList);
        }

        private List<Customer> GenerateExpectedCustomerList()
        {
            List<Customer> expectedList = new List<Customer> {_customer};
            return expectedList;
        }
    }
}
