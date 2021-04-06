using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace Store
{
    class Meaty : FoodProduct, IRefrigerator
    {
        private int temp;
        public Meaty()
        {

        }
        public Meaty(string name, int price, string isbn, Date date) : base(name, price, isbn, date)
        {

        }

        public int Temp { 
            get { return temp; } 
            set { if (value > 0 && value < 6) { temp = value; } } 
        } 
    }
}
