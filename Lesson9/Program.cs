using System;
using System.Threading;

namespace Lesson9
{
    class Program
    {
        static string lo = "";
        static void Main(string[] args)
        {
            Car[] cars = {
                new Car("a"),
                new Car("b"),
                new Car("c"),
                new Car("d"),
                new Car("e"),
                new Car("f"),
                new Car("g"),
                new Car("h"),
                new Car("i"),
                new Car("j"),
            };
            while(true)
            {
                Console.WriteLine("Choose car: ");
                cars[int.Parse(Console.ReadLine())].needsWash = true;
            }
        }
        public static void Wash(Car car)
        {
            Console.WriteLine(car.name + " is waiting");           
            lock (lo)
            {               
                Console.WriteLine(car.name + " starting wash");
                Thread.Sleep(5 * 1000);
                Console.WriteLine(car.name + " wash ended");
                car.needsWash = false;
            }
        }
    }
}
