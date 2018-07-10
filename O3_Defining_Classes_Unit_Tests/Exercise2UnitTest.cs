using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using O3_Defining_Classes_Exercise_1;

namespace O3_Defining_Classes_Unit_Tests
{
    [TestClass]
    public class Exercise2UnitTest
    {
        private readonly Team _team = new Team();

        [TestInitialize]
        public void Arrange()
        {
            _team.AddDevelopersToTeam();
        }

        [TestMethod]
        public void CreateDeveloper_ShouldSucceed()
        {
            //Arrange
            Developers evanDev = new Developers(1, "Havlin", true);

            //Act
            var expectedLastName = "Havlin";
            var actualLastName = evanDev.LastName;
            
            //Assert
            Assert.AreEqual(expectedLastName, actualLastName);
            
        }

        [TestMethod]
        public void DeveloperListCount_ShouldSucceed()
        {
            //Arrange
            
            //Act
            int expectedDevListCount = GetCountFromExpectedDevList();
            var actualDevListCount = _team.DevTeam.Count;

            //Assert
            Assert.AreEqual(expectedDevListCount, actualDevListCount);
        }

        private int GetCountFromExpectedDevList()
        {
            var maxDev = new Developers(1, "Holtman", true);
            var jaredDev = new Developers(2, "Niemeier", false);
            var evanDev = new Developers(3, "Havlin", true);

            var devList = new List<Developers> { maxDev, jaredDev, evanDev };
            return devList.Count;
        }
    }
}
