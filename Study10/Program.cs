using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Study10
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            List<Person> people = new List<Person>{
                new Person("a", 15),
                new Person("b", 18),
                new Person("c", 8),
                new Person("d", 60),
                new Person("e", 80),
                new Person("a", 115),
                new Person("f", 2),
                new Person("g", 37),
                new Person("h", 51),
                new Person("i", 99),
            };
            Person.PrintByFilter(people, Person.isAdult);
            Console.WriteLine();
            Person.PrintByFilter(people, Person.isChild);
            Console.WriteLine();
            Person.PrintByFilter(people, Person.isOld);

            // 2
            Calc calc1 = Calculator.AddP;
            calc1 += Calculator.SubP;
            Calc calc2 = Calculator.MultP;
            calc2 += Calculator.DivP;
            Calc calc3 = Calculator.AddP;
            Calc calc4 = Calculator.SubP;
            Console.WriteLine("For addition and sub press 1\nFor add press 2\nFor sub press 3\nFor multi and divide press 4");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    calc1(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                    break;
                case 2:
                    calc3(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                    break;
                case 3:
                    calc4(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                    break;
                case 4:
                    calc2(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                    break;
            }

            // 3
            Calc calc5 = Calculator.Add;
            calc5 += Calculator.Sub;
            Calc calc6 = Calculator.Mult;
            calc6 += Calculator.Div;
            Calc calc7 = Calculator.Add;
            Calc calc8 = Calculator.Sub;
            Console.WriteLine("For addition and sub press 1\nFor add press 2\nFor sub press 3\nFor multi and divide press 4");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine(calc5(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
                    break;
                case 2:
                    Console.WriteLine(calc7(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
                    break;
                case 3:
                    Console.WriteLine(calc8(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
                    break;
                case 4:
                    Console.WriteLine(calc6(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
                    break;
            }
            Console.WriteLine("For addition and sub press 1\nFor add press 2\nFor sub press 3\nFor multi and divide press 4");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    foreach (var item in calc5.GetInvocationList())
                    {
                        Console.WriteLine(item.DynamicInvoke(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
                    }
                    break;
                case 2:
                    foreach (var item in calc7.GetInvocationList())
                    {
                        Console.WriteLine(item.DynamicInvoke(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
                    }
                    break;
                case 3:
                    foreach (Calc item in calc8.GetInvocationList())
                    {
                        Console.WriteLine(item(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
                    }
                    break;
                case 4:
                    foreach (Calc item in calc6.GetInvocationList())
                    {
                        Console.WriteLine(item(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
                    }
                    break;
            }
        }
    }
}
