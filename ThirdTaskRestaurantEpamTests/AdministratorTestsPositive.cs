using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThirdTaskRestaurantEpam;
using ThirdTaskRestaurantEpam.Characters;

namespace ThirdTaskRestaurantEpamTests
{
    [TestClass]
    public class AdministratorTestsPositive
    {
        
        [TestMethod]
        public void TestAddClient()
        {
            uint validAdminId = 1;
            String validName = "B";
            String validPatronymic = "BB";
            String validSecondname = "BBB";
            uint validPassportId = 1111;
            uint validNumberOfMoney = 5;
           
            Administator administator = new Administator(validAdminId, validName, validPatronymic, validSecondname);
            Client client = new Client(validName, validSecondname, validPassportId, validNumberOfMoney);
            administator.AddClient(client);
            int expectedSizeOfClientsList = 1;
            Assert.AreEqual(expectedSizeOfClientsList, ClientList.ClientsList.Count);
        }

        [TestMethod]
        public void TestCreateHall()
        {
            Administator administator = new Administator(1, "BB", "BB", "BBB");
            administator.CreateHall();
            uint expectedNumberOfFreeTables = Hall.GetMaxQuantityOfTables;
            Assert.AreEqual(expectedNumberOfFreeTables, (uint)Hall.GetNumberOfFreeTables());
        }

    }
}
