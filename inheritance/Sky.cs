using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Sky: Vehicle
    {
        private double maxHight;

        public double MaxHight
        {
            get { return maxHight; }
            set { maxHight = value; }
        }
        public override string ToString()
        {
            return base.ToString() + " " + MaxHight;
        }

    }
}
