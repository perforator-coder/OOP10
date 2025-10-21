using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boookthis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cbook book = new Cbook("test");
            book.Read();
            Cbook book_1 = new Cbook("test",0);
            book_1.Read();
            Cbook book_2 = new Cbook();
            book_2.Read();
        }
    }
}
