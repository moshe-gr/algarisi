using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace Store
{
    class FruAndVegs : FoodProduct
    {
        public FruAndVegs()
        {

        }
        public FruAndVegs(string name, int price, string isbn, Date date) : base(name, price, isbn, date)
        {

        }
    }
}
