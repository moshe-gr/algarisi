using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Shirt
    {
        public int size;
        public string brand;
        public Color color;
        public Shirt(int size, string brand, Color color)
        {
            this.size = size;
            this.brand = brand;
            this.color = color;
        }
        public override string ToString()
        {
            return "Shirt brand: " + brand + ", Size: " + size + ", " + color;
        }
    }
}
