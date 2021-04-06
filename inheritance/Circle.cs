using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Circle: Shape
    {
        public Circle(): base("Circle")
        {

        }
        public override double S()
        {
            return Math.PI * Math.Pow(Length/2, 2);
        }
        public override double Perimeter()
        {
            return Math.PI * Length;
        }
    }
}
