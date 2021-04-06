using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace Store
{
    abstract class FoodProduct: Product, IExps
    {
        private Date expDate;

        public Date ExpDate
        {
            get { return expDate; }
            set { expDate = value; }
        }
        private bool needsRef;

        public bool NeedsRef
        {
            get { return needsRef; }
            set { needsRef = value; }
        }
        public FoodProduct()
        {

        }
        public FoodProduct(string name, int price, string isbn, Date date):base(name, price, isbn)
        {
            ExpDate = date;
        }
        public override string ToString()
        {
            return base.ToString() + "Expiration date: " + ExpDate + "\n";
        }
    }
}
