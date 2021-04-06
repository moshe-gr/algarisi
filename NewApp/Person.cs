using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewApp
{
    class Person
    {
        public string name, lastName;
        private int age;

        public int Age
        {
            get { return age; }
        }
        Person(int age)
        {
            this.age = age;
        }
        public static Person CreatePerson(int age) {
            if (age > 120 || age < 0)
            {
                throw new InValidAgeExeption();
            }
            return new Person(age);
        }
    }
}
