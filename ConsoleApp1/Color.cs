using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Color
    {
        public byte r;
        public byte g;
        public byte b;
        public override string ToString()
        {
            return "Color: rgb(" + r + ", " + g + ", " + b + ")";
        }
    }
}
