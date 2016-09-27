using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTaskRestaurantEpam.Characters
{
    public class Administator : Human
    {
        private uint id;

        public Administator(uint id, string name, string patronymic, string surname) : base(name, patronymic, surname)
        {
            this.id = id;
        }

        public void CreateHall()
        {
            for (uint i = 0; i < Hall.GetMaxQuantityOfTables; i++)
            {
                Table table = new Table(i + 1, false);
                Hall.FreeTablesList.Add(table);
            }
        }

        public void AddClient(Client client)
        {
            ClientList.ClientsList.Add(client);
        }
    }
}
