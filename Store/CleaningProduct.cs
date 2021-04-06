using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace Store
{
    abstract class CleaningProduct: Product, IHigihShelf, IExps
    {
        private Date expDate;

        public Date ExpDate
        {
            get { return expDate; }
            set { expDate = value; }
        }
        private bool isToxic;

        public bool IsToxic
        {
            get { return isToxic; }
            set { isToxic = value; }
        }
        public CleaningProduct()
        {

        }
        public CleaningProduct(string name, int price, string isbn, Date date):base(name, price, isbn)
        {
            ExpDate = date;
        }
        public override string ToString()
        {
            return base.ToString() + "Expiration date: " + ExpDate +"\n";
        }
    }
}
