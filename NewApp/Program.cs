using System;

namespace NewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] pList = new Person[11];
            try
            {
                pList[0] = Person.CreatePerson(20);
                pList[1] = Person.CreatePerson(26);
                pList[2] = Person.CreatePerson(20);
                pList[3] = Person.CreatePerson(20);
                pList[4] = Person.CreatePerson(20);
                pList[5] = Person.CreatePerson(20);
                pList[6] = Person.CreatePerson(20);
                pList[7] = Person.CreatePerson(20);
                pList[8] = Person.CreatePerson(15);
                pList[9] = Person.CreatePerson(20);
                pList[10] = Person.CreatePerson(20);                               
            }
            catch (InValidAgeExeption e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                foreach (Person person in pList)
                {
                    Console.WriteLine(person.Age);
                }
            }
            while (true)
            {
                try
                {
                    FindPerson(pList);
                    break;
                }
                catch (OutOfRangeExeption e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        public static void FindPerson(Person[] list)
        {
            try
            {
                int i = int.Parse(Console.ReadLine());
                Console.WriteLine(list[i].Age);
            }
            catch(IndexOutOfRangeException)
            {
                throw new OutOfRangeExeption();
            }
        }
    }
}
