using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    static class Shop
    {
        public static List<IRefrigerator> refrigerator = new List<IRefrigerator>();
        public static List<IExps> expShelf = new List<IExps>();
        public static List<IHigihShelf> highShelf = new List<IHigihShelf>();
        public static List<Elec> elecShelf = new List<Elec>();
        public static List<Product> products = new List<Product>();

        public static void Print()
        {
            foreach (IRefrigerator item in refrigerator)
            {
                Console.WriteLine("ref: " + item);
            }
            foreach (IExps item in expShelf)
            {
                Console.WriteLine("exp: " + item);
            }
            foreach (IHigihShelf item in highShelf)
            {
                Console.WriteLine("high: " + item);
            }
            foreach (Elec item in elecShelf)
            {
                Console.WriteLine("elec: " + item);
            }
            foreach (Product item in products)
            {
                Console.WriteLine("prod: " + item);
            }
        }
    }
}
