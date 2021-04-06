using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    static class Stocker
    {
        static public void SetProducts(List<Product> products)
        {
            foreach (Product item in products)
            {
                if(item is FoodProduct && ((FoodProduct)item).NeedsRef)
                {
                    Shop.refrigerator.Add((IRefrigerator)item);
                }
                else
                {
                    if (item is Elec)
                    {
                        Shop.elecShelf.Add((Elec)item);
                    }
                    else if ((item is CleaningProduct && ((CleaningProduct)item).IsToxic) || (item is HomeProduct && ((HomeProduct)item).Breakable))
                    {
                        Shop.highShelf.Add((IHigihShelf)item);
                    }
                    else if (item is IExps)
                    {
                        Shop.expShelf.Add((IExps)item);
                    }
                    else
                    {
                        Shop.products.Add(item);
                    }
                }
            }
        }

    }
}
