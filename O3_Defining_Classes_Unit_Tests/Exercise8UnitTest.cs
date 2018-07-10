using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using O4_OOP_Encapsulation_Exercise_4;

namespace O3_Defining_Classes_Unit_Tests
{
    [TestClass]
    public class Exercise8UnitTest
    {
        private Developer _developer;
        private DeveloperRepo _developerRepo;
        private const int STARTING_BALANCE = 100;

        [TestInitialize]
        public void Arrange()
        {
            _developer =  new Developer(new List<Courses>() {Courses.MusicHistory, Courses.CalculusI}, STARTING_BALANCE);
            _developerRepo = new DeveloperRepo();
        }

        [TestMethod]
        public void CreateDeveloper_ShouldSucceed()
        {
            //Arrange
            //Act
            var expectedCourseList = new List<Courses>() {Courses.MusicHistory, Courses.CalculusI};
            //Assert
            CollectionAssert.AreEqual(expectedCourseList, _developer.CourseList);
        }

        [TestMethod]
        public void CalculateEnrollmentTotal_ShouldSucceed()
        {
            //Arrange
            //Act
            var actualTotal = _developerRepo.GetEnrollmentTotal(_developer);
            var expectedTotal = 50;
            //Assert
            Assert.AreEqual(expectedTotal, actualTotal);

        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Insufficient funds.")]
        public void InsufficientFundsException_ShouldSucceed()
        {
            //Act
            Developer bankruptDeveloper = new Developer(new List<Courses>()
            { Courses.MusicHistory, Courses.CalculusI, Courses.Chemistry }, STARTING_BALANCE);
            //Assert
            _developerRepo.GetEnrollmentTotal(bankruptDeveloper);

        }

    }
}
