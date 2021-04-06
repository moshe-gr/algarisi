using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            while (true)
            {
                Console.WriteLine("Choose a number: ");
                try
                {
                    a = double.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            while (true)
            {
                Console.WriteLine("Choose a second number: ");
                try
                {
                    b = double.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }           
            Console.WriteLine("Choose a operator: ");
            string oper = Console.ReadLine();
            if(oper == "+")
            {
                Console.WriteLine(a + b);
            }
            else if (oper == "-")
            {
                Console.WriteLine(a - b);
            }
            else if (oper == "*")
            {
                Console.WriteLine(a * b);
            }
            else if (oper == "/")
            {
                try
                {
                    int z = (int)(a / b);
                    Console.WriteLine(z);
                }
                catch(DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
