using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Cat
    {
        public string name;
        public int age;
        public double height;
        public string color;
        public string poroda;

        public int tail;

        public void SetTailLength(int x)
        {
            if ((x > 5)&(x < 50))
            {
                tail = x;
            }
        }

        public void GetTailLength()
        {
            Console.WriteLine($"Длина хвоста - {tail} сантиметров");
        }

    }
}
