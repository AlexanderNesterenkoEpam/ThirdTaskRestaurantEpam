using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThirdTaskRestaurantEpam;
using ThirdTaskRestaurantEpam.Characters;

namespace ThirdTaskRestaurantEpamTests
{
    [TestClass]
    public class ClientTestsPositive
    {
        uint validAdminId;
        String validName;
        String validSecondname;
        String validPatronymic;
        uint validPassportId;
        uint validNumberOfMoney;
        Client client;
        Order order;
        Administator administrator;
        MenuItem firstMenuItem;
        MenuItem secondMenuItem;
        string validMenuItemName;
        uint validMenuItemPrice;
        ushort validMenuItemVolume;
        ushort validMenuItemWeight;
       
            
        [TestInitialize]
        public void TestInitialize()
        {
            validAdminId = 1;
            validName = "B";
            validSecondname = "BB";
            validPatronymic = "BBB";
            validPassportId = 1111;
            validNumberOfMoney = 5;
            validMenuItemName = "BBBB";
            validMenuItemPrice = 2;
            validMenuItemVolume = 100;
            validMenuItemWeight = 100;
            client = new Client(validName, validSecondname, validPassportId, validNumberOfMoney);
            administrator = new Administator(validAdminId, validName, validPatronymic, validSecondname);
            firstMenuItem = new Drink(validMenuItemName, validMenuItemPrice, validMenuItemVolume);
            secondMenuItem = new Food(validMenuItemName, validMenuItemPrice, validMenuItemWeight);
            order = new Order();
        }
        
        [TestMethod]
        public void TestBusyTableWithCreatedHall()
        {
            //Client client = new Client(validName, validSecondname, validPassportId, validNumberOfMoney);
            //Administator administator = new Administator(validAdminId, validName, validPatronymic, validSecondname);
            administrator.CreateHall();
            client.BusyTable();
            uint expectedNumberOfBusyTable = 1;
            uint expectedNumberOfFreeTable = Hall.GetMaxQuantityOfTables - 1;
            Assert.AreEqual(expectedNumberOfBusyTable, (uint)Hall.BusyTablesList.Count);
            Assert.AreEqual(expectedNumberOfFreeTable, (uint)Hall.GetNumberOfFreeTables());
        }

        [TestMethod]
        public void TestBusyTableWithoutCreatedHall()
        {
            client.BusyTable();
            uint expectedNumberOfBusyTable = 0;
            uint expectedNumberOfFreeTable = 0;
            Assert.AreEqual(expectedNumberOfBusyTable, (uint)Hall.BusyTablesList.Count);
            Assert.AreEqual(expectedNumberOfFreeTable, (uint)Hall.GetNumberOfFreeTables());
        }

        [TestMethod]
        public void TestChoseMenuItems()
        {
            client.ChoseMenuItems(firstMenuItem);
            client.ChoseMenuItems(secondMenuItem);
            uint expectedNumberOfMenuItems = 2;
            Assert.AreEqual(expectedNumberOfMenuItems, (uint)client.ChosenMenuItems.Count);
        }

        [TestMethod]
        public void TestMakeOrderWithTwoMenuItems()
        {
            client.ChoseMenuItems(firstMenuItem);
            client.ChoseMenuItems(secondMenuItem);
            uint expectedNumberOfMenuItems = 2;
            Assert.AreEqual(expectedNumberOfMenuItems, (uint)client.ChosenMenuItems.Count);
        }

        [TestMethod]
        public void TestMakeOrderWithNoOneMenuItem()
        {
            uint expectedNumberOfMenuItems = 0;
            Assert.AreEqual(expectedNumberOfMenuItems, (uint)order.OrderedMenuItems.Count);
        }

        [TestMethod]
        public void TestPayOrderWithTwoMenuItemsEnoughMoney()
        {
            client.ChoseMenuItems(firstMenuItem);
            client.ChoseMenuItems(secondMenuItem);
            client.MakeOrder(order);
            uint expectedNumberOfMoneyAfterPayOrder = validNumberOfMoney - firstMenuItem.Price - secondMenuItem.Price;
            Assert.AreEqual(expectedNumberOfMoneyAfterPayOrder,validNumberOfMoney - order.CalculateOrderSum());
        }

        [TestMethod]
        public void TestLeaveTable()
        {
            administrator.CreateHall();
            client.BusyTable();
            Assert.AreEqual(1, Hall.BusyTablesList.Count);
            client.LeaveTable();
            Assert.AreEqual(0, Hall.BusyTablesList.Count);
            
            
        }

    }
}
