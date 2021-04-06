using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libary
{
    class Libary
    {
        public static int numBooks;
        public static int numInLibary;
        public static void print()
        {
            Console.WriteLine("Number of books: {0}, Numbre of borowd books: {1}", numBooks, numBooks-numInLibary);
        }
    }
}
