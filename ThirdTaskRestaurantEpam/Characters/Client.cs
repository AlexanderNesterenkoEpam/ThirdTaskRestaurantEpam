using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTaskRestaurantEpam
{
    public class Client : Human
    {
        private uint passportId;
        private uint money;
        private List<MenuItem> chosenMenuItems = new List<MenuItem>();
        private Table table;
        //private bool IsTableNotBusyByClient = false;

        public uint PassportId
        {
            set { this.passportId = value; }
            get { return passportId; }
        }

        public uint Money
        {
            set { this.money = value; }
            get { return this.money; }
        }

        public List<MenuItem> ChosenMenuItems
        {
            set { chosenMenuItems = value; }
            get { return chosenMenuItems; }
        }

        public Client(string name, string surname, uint passportId, uint money) : base(name, surname)
        {
            this.passportId = passportId;
            this.money = money;
        }

        public void BusyTable()
        {
            int numberOfFreeTables = Hall.GetNumberOfFreeTables();

            if (numberOfFreeTables != 0)
            {
                table = Hall.GetFirstFreeTable();
                table.IsUsedNow = true;
                Hall.BusyTablesList.Add(table, this);
                Hall.FreeTablesList.Remove(table);
            }
            else
            {
                Console.WriteLine("There aren't free tables");
            }
        }

        /*
        public bool IsEnoughMoney()
        {
            return this.money > 0 ? true : false;
        }*/

        public void ChoseMenuItems(MenuItem menuItem)
        {
            chosenMenuItems.Add(menuItem);
        }

        public void MakeOrder(Order order)
        {
            if (chosenMenuItems.Count != 0)
            {
                order.OrderedMenuItems = chosenMenuItems;
            }
            else
            {
                Console.WriteLine("Client " + this.PassportId + " don't chose any menu item");
            }
        }

        public void PayOrder(Order order)
        {
            uint bill = order.CalculateOrderSum();
            if (money >= bill)
            {
                money -= bill;
            }
            else
            {
                Console.WriteLine("Call the police, Client " + this.PassportId + " haven't got enough money");
            }
        }


        public void LeaveTable()
        { 
            try
            {
                Hall.BusyTablesList.Remove(table);
                Hall.FreeTablesList.Add(table);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Number of tables must be > 0");
                Environment.Exit(0);
            }

        }
    }
}


