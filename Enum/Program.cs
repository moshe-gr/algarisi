using System;

namespace EnumStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(typeof(Months));
            string[] str = Enum.GetNames(typeof(Months));
            foreach (string item in str)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Choose month:");
            int month = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine((Months)month);
            Console.WriteLine("Type name of month: ");
            Enum.TryParse(Console.ReadLine(), true,  out Months m);                        
            Console.WriteLine(m);
        }
        enum Months{
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
    }
}
