using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Cat
{
    internal class Cat : Animal
    {
        private int lives;
        private bool er_live;

        public Cat(string name,int lives) : base(name)
        {
            if (lives < 1 || lives > 9)
            {
                Console.WriteLine("Ошибка:число не в диапозоне.");
                er_live = true;
            }
            else
            {
                er_live = false;
                this.lives = lives;
            }
        }
        public Cat(string name):base(name)
        {
            this.lives = 9;
            this.er_live = false;
        }
        public int Livecheck
        {
            get { return lives; }
            set 
            {
                if (value < 1 || value > 9)
                {
                    Console.WriteLine("Ошибка:число не в диапозоне.");
                    er_live = true;
                }
                else 
                { 
                    lives = value;
                    er_live = false;
                }
            }
        }

        public void Meow()
        {
            if (lives != 0 && er_live == false)
            {
                lives--;
                Speck();
                Console.WriteLine($"{getName} мяукнул, жизней {lives}");
            }
            else
            {
               // Console.WriteLine("Жизней нет :(");
            }
        }
    }
}
