using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boookthis
{
    internal class Cbook
    {
        private int pages;
        private string name_book;
       // private bool er_name;
        private bool er_page;

        //конструкторы
        public Cbook()
        {
            this.pages = 1;
            this.name_book = "";
        }
        public Cbook(string name)
        { 
            this.name_book = name;
            this.pages = 100;
        }
        public Cbook(string name,int pages)
        {
            if (pages < 1 || pages > 5000)
            {
                Console.WriteLine("Ошибка: не в диапозоне.");
                er_page = true;
            }
            else
            {
            this.pages = pages;
            }
            this.name_book = name ;
        }
        
        public string Namecheck
        {
            get { return name_book; }
            set
            { 
             name_book = value ;
            }
        }
        public int Pages
        {
            get { return pages; }
            set
            {
                if (value < 1 || value > 5000)
                {
                    Console.WriteLine("Ошибка: не в диапозоне.");
                    er_page = true;
                }
                else
                {
                    pages = value;
                    er_page = false;
                }
            }
        }

        // название

        public void Read()
        {
            if (er_page == false)
            {
                Console.WriteLine($"Читаю книгу {name_book}, с {pages} страниц.");
            }
            
        }
    }
}
