using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Type a;
            Class1 b = new Class1();
            a = b.GetType();
            Console.WriteLine(a);
        }
    }
}
