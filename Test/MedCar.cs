using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class MedCar : Car
    {
        private bool forKids;

        public bool ForKids
        {
            get { return forKids; }
            set { forKids = value; }
        }

        public override int MaxSeats => 20;
        public MedCar(string color, string model, int id) : base(color, model, id)
        {

        }
    }
}
