using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using O5_OOP_Inheritance_Exercise_2;

namespace O3_Defining_Classes_Unit_Tests
{
    [TestClass]
    public class Exercise9UnitTest
    {
        [TestMethod]
        public void CreateJuniorDeveloper_ShouldSucceed()
        {
            //Arrange
            Junior junior = new Junior(false, true, 2, false, false, "");
            //Act
            const string expectedJuniorName = "Holtman";
            junior.LastName = "Holtman";
            var actualJuniorName = junior.LastName;
            //Assert
            Assert.AreEqual(expectedJuniorName, actualJuniorName);
        }

        [TestMethod]
        public void CreateJuniorDeveloperSkillset_ShouldSucceed()
        {
            //Arrange
            var junior = new Junior(false, true, 2, false, false, "")
            { Languages = new Dictionary<string, int>()};
            //Act
            junior.Languages.Add("CSharp", 3);
            junior.Languages.Add("Flux", 6);
            var expectedLanguages = new Dictionary<string, int> {{"CSharp", 3}, {"Flux", 6}};
            var actualLanguages = junior.Languages;
            //Assert
            CollectionAssert.AreEqual(expectedLanguages, actualLanguages);
        }

        [TestMethod]
        public void CreateSeniorDeveloperSkillset_ShouldSucceed()
        {
            //Arrange
            var junior = new Senior(false, true, 2, false, "Graupner")
                { Languages = new Dictionary<string, int>() };
            //Act
            junior.Languages.Add("AngularJS", 5);
            junior.Languages.Add("CSharp", 8);
            var expectedLanguages = new Dictionary<string, int>
                { { "AngularJS", 5 }, { "CSharp", 8 } };
            var actualLanguages = junior.Languages;
            //Assert
            CollectionAssert.AreEqual(expectedLanguages, actualLanguages);
        }
    }
}
