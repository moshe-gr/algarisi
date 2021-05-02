using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study10
{
    class Calculator
    {
        public static int AddP(int a, int b)
        {
            Console.WriteLine(a + b);
            return a + b;
        }
        public static int SubP(int a, int b)
        {
            Console.WriteLine(a - b);
            return a - b;
        }
        public static int MultP(int a, int b)
        {
            Console.WriteLine(a * b);
            return a * b;
        }
        public static int DivP(int a, int b)
        {
            Console.WriteLine(a / b);
            return a / b;
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Sub(int a, int b)
        {
            return a - b;
        }
        public static int Mult(int a, int b)
        {
            return a * b;
        }
        public static int Div(int a, int b)
        {           
            return a / b;
        }
    }
    delegate int Calc(int a, int b);
    
}
