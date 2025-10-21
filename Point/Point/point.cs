using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    internal class point
    {
        private double x;
        private double y;

        // конструктор
        public point()
        { 
            this.x = this.y = 0;
        }
        public point(double x)
        { 
            this.x = this.y = x;
        }
        public point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double Xcheck
        {
            get { return x; }
            set { x = value; }  
        }
        public double Ycheck
        {
            get { return y; }
            set { y = value; }
        }
        public void Show()
        {
            Console.WriteLine($"Точка: {x} , {y}");
        }
    }
}
