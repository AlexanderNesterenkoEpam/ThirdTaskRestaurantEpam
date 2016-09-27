using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTaskRestaurantEpam
{
    public class MenuItem
    {
        private uint price;
        private string name;

        public uint Price
        {
            set { this.price = value; }
            get { return this.price; }
        }

        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }

        public MenuItem(string name, uint price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
