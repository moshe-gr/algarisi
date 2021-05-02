using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study10
{
    class Person: IComparable<Person>
    {
        string name;
        int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public static bool isChild(Person p)
        {
            return p.age < 18;
        }
        public static bool isAdult(Person p)
        {
            return !isChild(p);
        }
        public static bool isOld(Person p)
        {
            return p.age >= 60;
        }
        public static void PrintByFilter(List<Person> people, ChekAge chekAge)
        {
            people.FindAll(p => chekAge(p)).ForEach(p => Console.WriteLine(p));
        }
        public override string ToString()
        {
            return name + " " + age + ".";
        }

        public int CompareTo(Person other)
        {
            return age - other.age;
        }
    }
    delegate bool ChekAge(Person p);
}
