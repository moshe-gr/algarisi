using System;

namespace StudyForTest
{
    class Program
    {
        static void Main(string[] args)
        {
            University university1 = new University("Jbh");
            University university2 = new University("Hebrew");
            University university3 = new University("Haifa");
            for (int i = 0; i < 30; i++)
            {
                try
                {
                    StudentGenerator(university1);
                }
                catch(DuplicateRecordException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            university1.students.Sort();
            Console.WriteLine(university2.ToString() + " num of students: " + university1.num_of_student);
            Console.WriteLine(university1.ToString() + " total tuition: " + City.TuitionSum(university1));
            City.PrintDetails(university1);
            for (int i = 0; i < 30; i++)
            {
                try
                {
                    StudentGenerator(university2);
                }
                catch (DuplicateRecordException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            university2.students.Sort();
            Console.WriteLine(university2.ToString() + " num of students: " + university2.num_of_student);
            Console.WriteLine(university2.ToString() + " total tuition: " + City.TuitionSum(university2));
            City.PrintDetails(university2);
            for (int i = 0; i < 30; i++)
            {
                try
                {
                    StudentGenerator(university3);
                }
                catch (DuplicateRecordException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            university3.students.Sort();
            Console.WriteLine(university2.ToString() + " num of students: " + university3.num_of_student);
            Console.WriteLine(university3.ToString() + " total tuition: " + City.TuitionSum(university3));
            City.PrintDetails(university3);
        
    
        }

        public static void StudentGenerator(University university)
        {
            int rnd = new Random().Next(0, 3);
            switch (rnd)
            {
                case 0:
                    Student student = new Student("" + (char) new Random().Next(65, 91), new Random().Next(50));
                    City.AddStudent(university, student);
                    break;
                case 1:
                    ScholarshipStudent student1 = new ScholarshipStudent("" + (char)new Random().Next(65, 91), new Random().Next(50));
                    student1.scholarship_sum = new Random().Next(100, 9901);
                    City.AddStudent(university, student1);
                    break;
                case 2:
                    FamilyStudent student2 = new FamilyStudent("" + (char)new Random().Next(65, 91), new Random().Next(50));
                    student2.level = new Random().Next(1, 4);
                    City.AddStudent(university, student2);
                    break;
            }
        }
    }
}
