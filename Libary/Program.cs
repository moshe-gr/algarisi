using System;
using System.Collections.Generic;

namespace Libary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> booksList = new List<Book>();
            for(int i = 0; i < 20; i++)
            {
                booksList.Add(Book.add());
            }
            Libary.print();
            foreach(Book item in booksList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
