using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lesson10
{
    class Program
    {
        static void Main(string[] args)
        {
            //recrusion
            Console.WriteLine("recrusion");
            List<double> list = new List<double>();            
            Fibonachi(10, list);

            //directory and file handling
            Console.WriteLine("\ndirectory and file handling");
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\stu\source\repos\Lesson10\bin\Debug\net5.0");
            Console.WriteLine(DirSize(directory));
            Console.WriteLine(directory.GetDirectories().Length);

            //delegates
            Console.WriteLine("\ndelegates");
            MyDelegate myDelegate = FibonachiPrint;
            myDelegate += DelTest;
            myDelegate.Invoke(5);

            //string building
            Console.WriteLine("\nstring building");
            StringBuilder builder = new StringBuilder();
            builder.Append("a");
            builder.Append("b");
            builder.Append("c");
            builder.Append("d");
            Console.WriteLine(builder);
        }
        public static void DelTest(int n)
        {
            Console.WriteLine(n);
        }
        public static void Fibonachi(int n, List<double> list)
        {
            if(n == 1)
            {
                list.Add(1);
                Console.WriteLine(list[n - 1]);
            }
            else if (n == 2)
            {
                list.Add(1);
                Fibonachi(n - 1, list);
                Console.WriteLine(list[n - 1]);
            }
            else
            {
                Fibonachi(n - 1, list);
                list.Add(list[n - 2] + list[n - 3]);
                Console.WriteLine(list[n-1]);
            }   
        }
        public static int Fibonachi(int n)
        {
            if(n <= 2)
            {
                return 1;
            }
            return Fibonachi(n - 1) + Fibonachi(n - 2);
        }
        public static void FibonachiPrint(int n)
        {
            if(n > 0)
            {
                FibonachiPrint(n - 1);
                Console.WriteLine(Fibonachi(n));
            }            
        }
        public static long DirSize(DirectoryInfo directory)
        {
            int i = directory.GetDirectories().Length;
            long sum = 0;
            foreach (var item1 in directory.GetFiles())
            {
                sum += item1.Length;
            }
            foreach (var item1 in directory.GetDirectories())
            {
                foreach (var item2 in item1.GetFiles())
                {
                    sum += item2.Length;
                }
            }
            return sum;
        }
    }    
}