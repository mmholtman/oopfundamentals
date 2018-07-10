using System;
using System.Diagnostics;
using C2_Reference_Types;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Reference_Types_UnitTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void SetCustomer_ShouldSucceed()
        {
            Customer customer = new Customer("Mario", "plumber@mushroomkingdom", "3172199322");
            var actual = customer.Name;
            string expected = "Mario";
            Console.WriteLine(expected);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void CreateCustomer_ShouldSucceed()
        {
            Customer customer = new Customer();
            var actualCustomer = customer.CreateCustomer();
            string expected = "Max";
            var actualName = actualCustomer.Name;
            Console.WriteLine(actualName);

            Assert.AreEqual(expected, actualName);

        }
    }
}
