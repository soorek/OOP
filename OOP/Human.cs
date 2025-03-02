using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Human
    {
        public int age;
        public int Height;
        public string Name;

        public void SetName(string new_name)
        {
            Name = new_name;
        }

        public void GetName()
        {
            Console.WriteLine($"Меня зовут {Name}");
        }


    }

    


}
