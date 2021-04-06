using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace Store
{
    class Dishes: CleaningProduct
    {
        public Dishes()
        {

        }
        public Dishes(string name, int price, string isbn, Date date) : base(name, price, isbn, date)
        {
            
        }
    }
}
