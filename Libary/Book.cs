using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libary
{
    class Book
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string author;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }


        private int numPages;

        public int NumPages
        {
            get { return numPages; }
            set { numPages = value; }
        }
        private bool inLibary;

        public bool InLibary
        {
            get { return inLibary; }
            set { inLibary = value;
                if (value) {
                    Libary.numInLibary++;
                }
            }
        }
        public Book(string name, string author)
        {
            Name = name;
            Author = author;
            NumPages = new Random().Next(100, 700);
        }
        public override string ToString()
        {
            return string.Format("Name of book: {0}\nAuthor: {1}\nNum of pages: {2}\nIn libary: {3}.\n", Name, Author, NumPages, InLibary?"Yes":"No");
        }
        public static Book add()
        {
            Libary.numBooks++;
            Console.WriteLine("Name of book? ");
            string name = Console.ReadLine();
            Console.WriteLine("Name of author? ");
            string author = Console.ReadLine();
            Book book = new Book(name, author);
            book.InLibary = new Random().Next() % 3 != 0;
            return book;
        }
    }
}