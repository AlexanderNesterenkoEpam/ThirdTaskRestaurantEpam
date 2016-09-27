using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTaskRestaurantEpam
{
    public class Order
    {
        private List<MenuItem> orderedItems = new List<MenuItem>();

        private Dictionary<Client, List<MenuItem>> order = new Dictionary<Client, List<MenuItem>>();

        public List<MenuItem> OrderedMenuItems
        {
            set { this.orderedItems = value; }
            get { return orderedItems; }
        }

        public uint CalculateOrderSum()
        {
            uint bill = 0;
            foreach(MenuItem menuItem in orderedItems)
            {
                bill += menuItem.Price;
            }

            return bill;
        }

        public Dictionary<Client, List<MenuItem>> ClientOrder 
        {
            set { this.order = value; }
            get { return order; }
        }

    }
}
