using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Shape
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int length;

        public int Length
        {
            get { return length; }
            set { length = value; }
        }
        private int width;

        public int Width
        {
            get { return width; }
            set { width = value; }
        }


        public Shape(string name)
        {
            Name = name;   
        }
        public virtual double S()
        {
            return Length * Width;
        }
        public virtual double Perimeter()
        {
            return (Length * 2) + (Width * 2);
        }
        public override string ToString()
        {
            return Name + ": " + "Perimeter: " + Perimeter() + " Area: " + S();
        }
    }
}
