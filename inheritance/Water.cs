using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Water: Vehicle
    {
        private bool canDive;

        public bool CanDive
        {
            get { return canDive; }
            set { canDive = value; }
        }
        public override string ToString()
        {
            return base.ToString() + " " + CanDive;
        }

    }
}
