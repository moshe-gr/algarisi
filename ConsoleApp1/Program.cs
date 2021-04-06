using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Color gray = new Color();
            ////gray.r = 128;
            ////gray.g = 128;
            ////gray.b = 128;
            ////Color black = new Color();
            ////Color red = new Color();
            ////red.r = 255;
            ////Color blue = new Color();
            ////blue.b = 225;
            ////Color white = new Color();
            ////white.r = 255;
            ////white.g = 255;
            ////white.b = 255;
            ////Line l1 = new Line(new Point(3, 5), new Point(2, 6), 5.5);
            ////Line l2 = new Line(new Point(-3, -1), new Point(1, 4), 2.4);
            ////Line l3 = new Line(new Point(1, 3), new Point(-2, 5), 7.9);
            ////Car car1 = new Car("hyunday", 15000, gray);
            ////Car car2 = new Car("Subaru", 13000, red);
            ////Car car3 = new Car("Volvo", 20000, blue);
            ////Car car4 = new Car("Audi", 105000, black);
            ////Shirt shirt1 = new Shirt(15, "Charles tyrwhit", white);
            ////Shirt shirt2 = new Shirt(15, "Polo", blue);
            ////Shirt shirt3 = new Shirt(14, "Charles tyrwhit", white);
            //// Person[] pepole = new Person[6]; { 
            ////    new Person("Avi", "Cohen"), 
            ////    new Person("Jon", "Jons"), 
            ////    new Person("Moshe", "Greenberg", new Date { Day = 5, Month = 6, Year = 1992 }),
            ////    new Person("Shifra", "Greenberg", new Date { Day = 3, Month = 2, Year = 1992 }),
            ////    new Person("Daniell", "Weisz", 26, 11, 1965),
            ////    new Person("Sara", "Weisz", 15, 9, 1971)
            ////};
            Person p = new Person("Moshe", "Greenberg", 5, 6, 1992);
            Person p1 = new Person(p);
            Console.WriteLine(p);
            Console.WriteLine(p1);
            p1.name = "Avi";
            Console.WriteLine(p);
            Console.WriteLine(p1);
            p.lastName = "Levi";
            p1.date.Day = 6;
            p1.date.Year = 1981;
            Console.WriteLine(p);
            Console.WriteLine(p1);


            //Console.WriteLine(l1);
            //Console.WriteLine(l2);
            //Console.WriteLine(l3);
            //Console.WriteLine(car1);
            //Console.WriteLine(car2);
            //Console.WriteLine(car3);
            //Console.WriteLine(car4);
            //Console.WriteLine(shirt1);
            //Console.WriteLine(shirt2);
            //Console.WriteLine(shirt3);
            //while (true)
            //{
            //    Console.WriteLine("Choose name:");
            //    string choice = Console.ReadLine();
            //    foreach (Person person in pepole)
            //    {
            //        if (choice == person.name)
            //        {
            //            Console.WriteLine(person);
            //        }
            //    }
            //}           
        }
    }    
}
