using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Triangle: Shape
    {
        public Triangle(): base("Triangle")
        {
                
        }
        public override double S()
        {
            return base.S() / 2;
        }
        public override double Perimeter()
        {
            return Length * 3;
        }
    }
}
