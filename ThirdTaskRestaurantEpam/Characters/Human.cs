using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTaskRestaurantEpam
{
    public class Human
    {
        private string name;
        private string patronymic;
        private string surname;
        //private byte age;

        public Human(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public Human(string name, string patronymic, string surname)
        {
            this.name = name;
            this.patronymic = patronymic;
            this.surname = surname;
        }

    }
}
