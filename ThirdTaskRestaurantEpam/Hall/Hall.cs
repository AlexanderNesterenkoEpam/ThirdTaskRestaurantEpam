using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTaskRestaurantEpam
{
     public class Hall
    {
        private static List<Table> freeTablesList = new List<Table>();// number of free tables
        private static Dictionary<Table, Client> busyTablesList = new Dictionary<Table, Client>();// number of busy tables
        private static readonly uint MAX_QUANTITY_OF_TABLES = 10;

        public static List<Table> FreeTablesList
        {
            get { return freeTablesList; }
            set { freeTablesList = value; }
        }

        public static Dictionary<Table, Client> BusyTablesList
        {
            set { busyTablesList = value; }
            get { return busyTablesList; }
        }

        public static int GetNumberOfFreeTables()
        {
            return freeTablesList.Count;
        }


        public static Table GetFirstFreeTable()
        {
            return freeTablesList.ElementAt(0);
        }

        public static uint GetMaxQuantityOfTables
        {
            get{ return MAX_QUANTITY_OF_TABLES; }
        }
    }
}
