using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using O4_OOP_Encapsulation_Exercise_2;

namespace O3_Defining_Classes_Unit_Tests
{
    [TestClass]
    public class Exercise6UnitTest
    {
        private Room _room;
        [TestInitialize]
        public void Arrange()
        {
            _room = new Room();
        }
        [TestMethod]
        public void CreateRoomDimensions_ShouldSucceed()
        {
            //Arrange
            var room = new Room(11, 14.2, 8.5);

            //Act
            const double expectedWidth = 14.2;
            var actualWidth = room.Width;
            //Assert
            Assert.AreEqual(expectedWidth, actualWidth);
        }

        [TestMethod]
        public void CalculateSurfaceArea_ShouldSucceed()
        {
            //Arrange
            var exampleRoom = new Room(11, 14.2, 8.5);

            //Act
            var actualResult = _room.CalculateSurfaceArea(exampleRoom);
            const double expectedResult = 93.5;
            Console.WriteLine(actualResult);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "The length is outside the specified range.")]
        public void GetAndSetLength_CatchException()
        {
            //Arrange
            var room = new Room(11, 14.2, 100);
        }

        [DataTestMethod]
        [DataRow(10, 14.2, 8.5)]
        [DataRow(11, 17.2, 8)]
        [DataRow(12, 10, 10)]
        public void _8_ConstructorWorksWithMultipleParams(double h, double w, double l)
        {
            var room = new Room(h, w, l);
            Console.WriteLine(room);
        }
    }
}
