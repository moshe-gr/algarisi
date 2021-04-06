using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Cleaning : HomeProduct 
    {
        public Cleaning()
        {

        }
        public Cleaning(string name, int price, string isbn, int warranty) : base(name, price, isbn, warranty)
        {
            
        }
    }
}
