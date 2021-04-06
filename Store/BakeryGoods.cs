using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace Store
{
    class BakeryGoods : FoodProduct, IExps
    {
        public BakeryGoods()
        {
            
        }
        public BakeryGoods(string name, int price, string isbn, Date date):base(name, price, isbn, date)
        {
            
        }
    }
}
