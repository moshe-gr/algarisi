using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Elec : HomeProduct
    {
        public Elec()
        {

        }
        public Elec(string name, int price, string isbn, int warranty) : base(name, price, isbn, warranty)
        {
            
        }
    }
}
