using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class LrgCar : Car
    {
        public override int MaxSeats => 50;
        private int numStanding;

        public int NumStanding
        {
            get { return numStanding; }
            set { numStanding = value; }
        }
        private int maxWaight;

        public int MaxWaight
        {
            get { return maxWaight; }
            set { maxWaight = value; }
        }
        public LrgCar(string color, string model, int id, int maxWaight) : base(color, model, id)
        {
            MaxWaight = maxWaight;
        }
        public override bool CanDrive(Driver driver)
        {
            return base.CanDrive(driver) && driver.maxWaight >= this.maxWaight;
        }

    }
}
