using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Device
{
    internal class Device
    {
        private string brand;

        public Device(string name)
        { 
            this.brand = name;
        }
        public string Name { 
            get { return brand; }
            set { brand = value; }
        }
        public void Brand()
        {
            Console.WriteLine($"{brand} включен.");
        }
    }
}
