using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdTaskRestaurantEpam.Characters;

namespace ThirdTaskRestaurantEpam
{
    public class Beginner
    {
        public void BeginWork()
        {
            Administator admin = new Administator(1,"Sergey", "Alexandrovich", "Leshkovich");
            admin.CreateHall();
           
            Client firstClient = new Client("Alexander", "Nesterenko", 2220327, 0);
           
            admin.AddClient(firstClient);

            firstClient.BusyTable();
      
            Console.WriteLine("Used tables. User at table " + Hall.BusyTablesList.Count);
            Console.WriteLine("Free tables. User at table "+ Hall.FreeTablesList.Count);

            MenuItem dish = new Food("Burger", 10, 300);
            MenuItem drink = new Drink("Cofee",3, 200);

           //firstClient.ChoseMenuItems(dish);
           //firstClient.ChoseMenuItems(drink);

            Order orderFirstClient = new Order();

            firstClient.MakeOrder(orderFirstClient);
            firstClient.PayOrder(orderFirstClient);
            //firstClient.LeaveTable();

          // Console.WriteLine("Used tables. User leave table " + Hall.BusyTablesList.Count);
           // Console.WriteLine("Free tables. User leave table " + Hall.FreeTablesList.Count);

        }
    }
}
