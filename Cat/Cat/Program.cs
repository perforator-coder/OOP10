using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat Act = new Cat("Барсик");
            Act.Meow();//проверка
            Act.Meow();
            Act.Meow();
            Act.Meow();
            Act.Meow();
            Act.Meow();

        }
    }
}
