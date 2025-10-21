using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Device
{
    internal class Laptop : Device
    {
        private int ram;
        private int Batt;
        private bool er_ram;
        private bool er_batt;
        public Laptop(string name,int ram,int Batt):base(name)
        {
            Device input = new Device(name);
            if (ram < 1)
            {
                Console.WriteLine("Ошибка:память не может быть меньше или равно 0.");
                er_ram = true;
            }
            else
            {
                this.ram = ram;
                er_ram = false;
            }
            if (Batt < 0 || Batt > 100)
            {
                Console.WriteLine("Ошибка:Батаеря не может быть меньше 0 или больше 100.");
                er_batt = true;
            }
            else
            {
                this.Batt = Batt;
                er_batt = false;
            }
        }

        public int Ramcheck
        {
            get { return ram; }
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Ошибка:память не может быть меньше или равно 0.");
                    er_ram = true;
                }
                else
                {
                    ram = value;
                    er_ram = false;
                }
            }
        }
        public int Battcheck
        {
            get { return Batt; }
            set
            {
                if (value < 0 || value > 100)
                {
                    Console.WriteLine("Ошибка:Батаеря не может быть меньше 0 или больше 100.");
                    er_batt = true;
                }
                else
                {
                    Batt = value;
                    er_batt = false;
                }

            }
        }
        public void Work()
        {
            if (er_batt == false && er_ram == false)
            { 
                
                Console.WriteLine($"Ноутбук {Name}, Ram:{ram}, Batt:{Batt}%");
            }
        }
    }
}
