using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using O3_Defining_Classes_Exercise_4;

namespace O3_Defining_Classes_Unit_Tests
{
    [TestClass]
    public class Exercise4UnitTest
    {
        private SalesMember _salesMember;
        private readonly SalesMemberRepo _salesMemberRepo = new SalesMemberRepo();

        [TestInitialize]
        public void Arrange()
        {
            _salesMember = new SalesMember();
        }

        [TestMethod]
        public void CreateSalesMember_ShouldSucceed()
        {
            //Arrange
            _salesMember.LastName = "Holtman";
            _salesMember.TotalSalesForCurrentMonth = 200;

            //Act
            var actualLastName = _salesMember.LastName;
            var expectedLastName = "Holtman";
            //Assert
            Assert.AreEqual(expectedLastName, actualLastName);
        }

        [TestMethod]
        public void GetTotalTeamSales_ShouldSucceed()
        {
            //Arrange        
            _salesMember.TotalSalesForCurrentMonth = 200;
            _salesMemberRepo.AddMemberToList(_salesMember);
            SalesMember salesMember2 = new SalesMember { TotalSalesForCurrentMonth = 300 };
            _salesMemberRepo.AddMemberToList(salesMember2);

            //Act
            var actualTotal = _salesMemberRepo.GetTotalTeamSales();
            var expectedTotal = 500;
            //Assert
            Assert.AreEqual(expectedTotal, actualTotal);
        }

        [TestMethod]

        public void AddMemberToTeam_ShouldSucceed()
        {
            //Arrange        

            //Act
            
            //Assert
            
        }
    }
}
