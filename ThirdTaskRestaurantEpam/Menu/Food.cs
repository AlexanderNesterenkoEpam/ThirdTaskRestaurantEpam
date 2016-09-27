using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTaskRestaurantEpam
{
    public class Food : MenuItem
    {
        private ushort weight;

        public ushort FoodWeight
        {
            set { this.weight = value; }
            get { return this.weight; }
        }

        public Food(string name, uint price, ushort weight) : base(name, price)
        {
            this.weight = weight;
        }
    }
}
