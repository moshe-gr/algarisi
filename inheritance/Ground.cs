using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Ground: Vehicle
    {
        private int numWheals;

        public int NumWheals
        {
            get { return numWheals; }
            set { numWheals = value; }
        }
        public override string ToString()
        {
            return base.ToString() + " " + NumWheals;
        }

    }
}
