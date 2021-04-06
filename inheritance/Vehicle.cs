using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Vehicle
    {
        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        private int maxCap;

        public int MaxCap
        {
            get { return maxCap; }
            set { maxCap = value; }
        }
        private int point;

        public int Point
        {
            get { return point; }
            set { point = value; }
        }
        public override string ToString()
        {
            return Color + " " + MaxCap + " " + Point;
        }


    }
}
