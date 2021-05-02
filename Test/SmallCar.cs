using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class SmallCar : Car
    {
        public override int MaxSeats => 4;
        public SmallCar(string color, string model , int id):base(color, model, id)
        {
                
        }
    }
}
