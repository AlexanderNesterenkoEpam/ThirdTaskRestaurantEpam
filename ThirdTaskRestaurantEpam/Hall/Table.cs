using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTaskRestaurantEpam
{
    public class Table
    {
        private bool isUsedNow;
        private uint number;

        public bool IsUsedNow
        {
            set { this.isUsedNow = value; }
            get { return this.isUsedNow; }
        }

        public uint Number
        {
            set { this.number = value; }
            get { return this.number; }
        }

        public Table(uint number, bool isUsedNow)
        {
            this.number = number;
            this.isUsedNow = isUsedNow;
        }
       
    }
}
