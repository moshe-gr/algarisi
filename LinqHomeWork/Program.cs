using System;
using System.IO;
using System.Linq;

namespace LinqHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintSearch(@"C:\Users\stu\Desktop\text.txt");
        }
        static void PrintSearch(string str)
        {
            var res = from a in File.ReadLines(str) where a.Contains("avi") select a;
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }
    }
}
