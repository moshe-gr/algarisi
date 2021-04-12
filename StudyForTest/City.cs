using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyForTest
{
    class City
    {
        public static void AddStudent(Student student)
        {
           if (University.students.Exists(stu => stu.id == student.id))
            {
                throw new DuplicateRecordException();
            }
            else
            {
                University.students.Add(student);
                University.num_of_student++;
            }
        }
        public static long TuitionSum()
        {
            long sum = 0;
            foreach (var item in University.students)
            {
                sum += item.Tuition();
            }
            return sum;
        }
        public static void PrintDetails()
        {
            foreach (var item in University.students)
            {
                Console.WriteLine(item);
            }
        }
    }
}
