using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    abstract class HomeProduct: Product, IHigihShelf
    {
        private bool breakable;

        public bool Breakable
        {
            get { return breakable; }
            set { breakable = value; }
        }
        private int warranty;

        public int Warranty
        {
            get { return warranty; }
            set { warranty = value; }
        }
        public HomeProduct()
        {

        }
        public HomeProduct(string name, int price, string isbn, int warranty):base(name, price, isbn)
        {
            Warranty = warranty;
        }
        public override string ToString()
        {
            return base.ToString() + "Warranty: " + (Warranty > 0 ? Warranty:"No warranty") + "\n";
        }
    }
}
