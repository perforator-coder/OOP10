using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Device
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Laptop lap = new Laptop("lol",-2, -12);
            lap.Work();
        }
    }
}
