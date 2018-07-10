using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using O4_OOP_Encapsulation_Exercise_3;

namespace O3_Defining_Classes_Unit_Tests
{
    [TestClass]
    public class Exercise7UnitTest
    {
        private YoungDriver _driver;
        [TestInitialize]
        public void Arrange()
        {
            _driver = new YoungDriver();
        }

        [DataTestMethod]
        [DataRow(17)]
        [DataRow(21)]
        [DataRow(24)]
        public void GetCost_ShouldSucceed(int a)
        {
            //Arrange
            var dataRowAge = Convert.ToInt32(a);
            //Act
            _driver.Age = a;
            _driver.GetCost();
            //Assert
            AssertCostPerAgeDataRow(dataRowAge);
        }
        private void AssertCostPerAgeDataRow(int age)
        {       
            var expectedCost = 0;
            var actualCost = _driver.Cost;
            switch (age)
            {
                case 17:
                    expectedCost = 228;
                    break;
                case 21:
                    expectedCost = 192;
                    break;
                case 24:
                    expectedCost = 180;
                    break;
                default:
                    break;
            }
            Assert.AreEqual(expectedCost, actualCost);
        }
        /*
        [TestMethod]
        [ExpectedException(typeof(Exception), "The age is outside the specified range.")]
        public void GetCost_ExceptionReached()
        {
            //Arrange
            YoungDriver youngDriver = new YoungDriver(100);
            _driver.GetCost(youngDriver);
        }
        */
    }
}
