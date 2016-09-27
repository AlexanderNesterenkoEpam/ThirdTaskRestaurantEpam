using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTaskRestaurantEpam
{
    public class ClientList
    {
        private static List<Client> clientsList = new List<Client>(); // list of clients
      
        public static List<Client> ClientsList
        {
            set { clientsList = value; }
            get { return clientsList; }

        }
    } 
}
