using System;

namespace StudyForTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("a", 1);
            Student s2 = new Student("b", 2);
            Student s3 = new Student("c", 3);
            Student s4 = new Student("d", 4);
            Student s5 = new Student("e", 5);
            Student s16 = new Student("e", 5);
            ScholarshipStudent s6 = new ScholarshipStudent("a", 6);
            ScholarshipStudent s7 = new ScholarshipStudent("f", 7);
            ScholarshipStudent s8 = new ScholarshipStudent("g", 8);
            ScholarshipStudent s9 = new ScholarshipStudent("b", 9);
            ScholarshipStudent s10 = new ScholarshipStudent("z", 10);
            ScholarshipStudent s17 = new ScholarshipStudent("z", 10);
            FamilyStudent s11 = new FamilyStudent("x", 11);
            FamilyStudent s12 = new FamilyStudent("x", 12);
            FamilyStudent s13 = new FamilyStudent("h", 13);
            FamilyStudent s14 = new FamilyStudent("a", 14);
            FamilyStudent s15 = new FamilyStudent("j", 15);
            FamilyStudent s18 = new FamilyStudent("j", 15);
            s6.scholarship_sum = 3000;
            s7.scholarship_sum = 568;
            s8.scholarship_sum = 7300;
            s9.scholarship_sum = 1624;
            s10.scholarship_sum = 2930;
            s11.level = new Random().Next(1, 4);
            s12.level = new Random().Next(1, 4);
            s13.level = new Random().Next(1, 4);
            s14.level = new Random().Next(1, 4);
            s15.level = new Random().Next(1, 4);
            try
            {
                City.AddStudent(s1);
            }
            catch(DuplicateRecordException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                City.AddStudent(s16);
            }
            catch (DuplicateRecordException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                City.AddStudent(s2);

            }
            catch (DuplicateRecordException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                City.AddStudent(s17);
            }
            catch (DuplicateRecordException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                City.AddStudent(s18);
            }
            catch (DuplicateRecordException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                City.AddStudent(s16);
                
            }
            catch (DuplicateRecordException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {

                City.AddStudent(s15);
            }
            catch (DuplicateRecordException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {

                City.AddStudent(s14);
            }
            catch (DuplicateRecordException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {

                City.AddStudent(s11);
            }
            catch (DuplicateRecordException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {

                City.AddStudent(s13);
            }
            catch (DuplicateRecordException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {

                City.AddStudent(s12);
            }
            catch (DuplicateRecordException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {

                City.AddStudent(s10);
            }
            catch (DuplicateRecordException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {

                City.AddStudent(s8);
            }
            catch (DuplicateRecordException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {

                City.AddStudent(s9);
            }
            catch (DuplicateRecordException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {

                City.AddStudent(s7);
            }
            catch (DuplicateRecordException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                City.AddStudent(s6);

            }
            catch (DuplicateRecordException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {

                City.AddStudent(s5);
            }
            catch (DuplicateRecordException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {

                City.AddStudent(s4);
            }
            catch (DuplicateRecordException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                City.AddStudent(s3);

            }
            catch (DuplicateRecordException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(City.TuitionSum());
            City.PrintDetails();
        }
    }
}
