using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Person
    {
        public string name;
        public string lastName;
        public Date date;
        public Person():this("???", "???")
        {

        }
        public Person(string name, string lastName):this(name, lastName, new Date { Day = 1, Month = 1, Year = 2010 })
        {
           
        }
        public Person(string name, string lastName, Date date):this(name, lastName, date.Day, date.Month, date.Year)
        {
                
        }
        public Person(string name, string lastName, int day, int month, int year)
        {
            this.name = name;
            this.lastName = lastName;
            this.date = new Date { Day = day, Month = month, Year = year };
        }
        public Person(Person copy):this(copy.name, copy.lastName, copy.date)
        {
                
        }
        public bool isOld(Person person)
        {
            return date.Year < person.date.Year;
        }
        public override string ToString()
        {
            return string.Format("Name: {0}, Last name: {1}, Birth date: {3}, Age: {2}", name, lastName, 2021 - date.Year, date);
        }
    }
}
