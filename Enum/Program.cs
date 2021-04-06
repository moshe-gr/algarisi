using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose month:");
            int month = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine((Months)month);
        }
        enum Months{
            a,
            b,
            c,
            d,
            e,
            f,
            g,
            h,
            i,
            j,
            k,
            l
        }
    }
}
