using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OO6_OOP_Polymorphism_Badges;

namespace O3_Defining_Classes_Unit_Tests
{
    [TestClass]
    public class BadgeUnitTest
    {
        BadgeA _badgeA;
        Badge _badge;
        IBadge _ibadge;
        [TestInitialize]
        public void Arrange()
        {
            _badgeA = new BadgeA(1);
        }

        [TestMethod]
        public void SetBadgeLevel_ShouldSucceed()
        {
            //Act
            var expectedBadgeLevel = 1;
            var actualBadgeLevel = _badgeA.Level = 1;
            //Assert
            Assert.AreEqual(expectedBadgeLevel, actualBadgeLevel);
        }

        [TestMethod]
        public void AllowAccess_ShouldSucceed()
        {
            //Act
            var expectedAccess = true;
            var actualAccess = _badge.AllowAccess(_badgeA.Level);
            //Assert
            Assert.AreEqual(expectedAccess, actualAccess);
        }

        [TestMethod]

        public void AddBadgeToBadges_ShouldSucceed()
        {
            //Arrange
            _badge.Badges.Add(_badgeA);
            //Act
            List<Badge> expectedBadges = new List<Badge>
            {
                _badgeA
            };
            var actualBadges = _badge.Badges;
            //Assert
            CollectionAssert.AreEqual(expectedBadges, actualBadges);
        }
    }
}
