using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyForTest
{
    class City
    {
        public static void AddStudent(University university, Student student)
        {
           if (university.students.Exists(stu => stu.id == student.id))
            {
                throw new DuplicateRecordException();
            }
            else
            {
                university.students.Add(student);
                university.num_of_student++;
            }
        }
        public static long TuitionSum(University university)
        {
            long sum = 0;
            foreach (var item in university.students)
            {
                sum += item.Tuition();
            }
            return sum;
        }
        public static void PrintDetails(University university)
        {
            foreach (var item in university.students)
            {
                Console.WriteLine(university.ToString() + " " + item);
            }
        }
    }
}
