using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Truck: ICanDrive
    {
        private int maxWaight;

        public int MaxWaight
        {
            get { return maxWaight; }
            set { maxWaight = value; }
        }
        public Truck(int max)
        {
            MaxWaight = max;
        }

        public bool CanDrive(Driver driver)
        {
            return driver.maxWaight >= this.maxWaight;
        }
    }
}
