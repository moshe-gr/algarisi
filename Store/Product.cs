using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    abstract class Product
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string desc;

        public string Desc
        {
            get { return desc; }
            set { desc = value; }
        }
        private int price;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        private  string isbn;

        public  string Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }
        public Product()
        {

        }
        public Product(string name, int price, string isbn)
        {
            Name = name;
            Price = price;
            Isbn = isbn;
        }
        public override string ToString()
        {
            return Name + ", " + Price + "$, " + Isbn + ".\n";
        }
    }
}
