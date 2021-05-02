using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ICanDrive[] cars = new ICanDrive[] {
                new SmallCar("a", "small", 1),
                new SmallCar("b", "small", 2),
                new MedCar("c", "med", 3),
                new MedCar("d", "med", 4),
                new LrgCar("e", "lrg", 5, 500),
                new LrgCar("e", "lrg", 5, 850),
                new LrgCar("e", "lrg", 5, 700),
                new Truck(900),
                new Truck(750),
                new Truck(820),
            };
            Driver d1 = new Driver();
            Driver d2 = new Driver();
            Driver d3 = new Driver();
            Driver d4 = new Driver();
            Driver d5 = new Driver();

            Console.WriteLine("name? ");
            d1.name = Console.ReadLine();
            Console.WriteLine("max? ");
            d1.maxWaight = int.Parse(Console.ReadLine());
            Console.WriteLine("1 for small 2 for med 3 for lrg: ");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    d1.typeOfLisnce = new SmallCar("", "", 0).GetType();
                    break;
                case 2:
                    d1.typeOfLisnce = new MedCar("", "", 0).GetType();
                    break;
                case 3:
                    d1.typeOfLisnce = new LrgCar("", "", 0, 0).GetType();
                    break;
            }
            Console.WriteLine("name? ");
            d2.name = Console.ReadLine();
            Console.WriteLine("max? ");
            d2.maxWaight = int.Parse(Console.ReadLine());
            Console.WriteLine("1 for small 2 for med 3 for lrg: ");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    d2.typeOfLisnce = new SmallCar("", "", 0).GetType();
                    break;
                case 2:
                    d2.typeOfLisnce = new MedCar("", "", 0).GetType();
                    break;
                case 3:
                    d2.typeOfLisnce = new LrgCar("", "", 0, 0).GetType();
                    break;
            }
            Console.WriteLine("name? ");
            d3.name = Console.ReadLine();
            Console.WriteLine("max? ");
            d3.maxWaight = int.Parse(Console.ReadLine());
            Console.WriteLine("1 for small 2 for med 3 for lrg: ");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    d3.typeOfLisnce = new SmallCar("", "", 0).GetType();
                    break;
                case 2:
                    d3.typeOfLisnce = new MedCar("", "", 0).GetType();
                    break;
                case 3:
                    d3.typeOfLisnce = new LrgCar("", "", 0, 0).GetType();
                    break;
            }
            Console.WriteLine("name? ");
            d4.name = Console.ReadLine();
            Console.WriteLine("max? ");
            d4.maxWaight = int.Parse(Console.ReadLine());
            Console.WriteLine("1 for small 2 for med 3 for lrg: ");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    d4.typeOfLisnce = new SmallCar("", "", 0).GetType();
                    break;
                case 2:
                    d4.typeOfLisnce = new MedCar("", "", 0).GetType();
                    break;
                case 3:
                    d4.typeOfLisnce = new LrgCar("", "", 0, 0).GetType();
                    break;
            }
            Console.WriteLine("name? ");
            d5.name = Console.ReadLine();
            Console.WriteLine("max? ");
            d5.maxWaight = int.Parse(Console.ReadLine());
            Console.WriteLine("1 for small 2 for med 3 for lrg: ");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    d5.typeOfLisnce = new SmallCar("", "", 0).GetType();
                    break;
                case 2:
                    d5.typeOfLisnce = new MedCar("", "", 0).GetType();
                    break;
                case 3:
                    d5.typeOfLisnce = new LrgCar("", "", 0, 0).GetType();
                    break;
            }
            foreach (var item in cars)
            {
                Console.WriteLine(d1.name + " " + item + item.CanDrive(d1));
            }
            foreach (var item in cars)
            {
                Console.WriteLine(d2.name + " " + item + item.CanDrive(d2));
            }
            foreach (var item in cars)
            {
                Console.WriteLine(d3.name + " " + item + item.CanDrive(d3));
            }
            foreach (var item in cars)
            {
                Console.WriteLine(d4.name + " " + item + item.CanDrive(d4));
            }
            foreach (var item in cars)
            {
                Console.WriteLine(d5.name + " " + item + item.CanDrive(d5));
            }
        }
    }
}
