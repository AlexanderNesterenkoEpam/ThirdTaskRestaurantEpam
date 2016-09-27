using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTaskRestaurantEpam
{
    public class Drink : MenuItem
    {
        private ushort volume;

        public ushort Volume
        {
            set { this.volume = value; }
            get { return this.volume; }
        }

        public Drink(string name, uint price, ushort volume) : base(name, price)
        {
            this.volume = volume;
        }

    }
}
