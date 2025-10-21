using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat
{
    internal class Animal
    {
        private string name;

        public Animal(string name)
        {
            this.name = name;
        }

        public string getName {
        get { return name; }
            set { name = value; }
        }
        public void Speck()
        {
            Console.WriteLine($"{name}, издает звук.");
        }
    }
}
