using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyForTest
{
    class Student
    {
        public string name;
        public long id;
        public Student(string name, long id)
        {
            this.name = name;
            this.id = id;
        }
        public Student(Student student): this(student.name, student.id)
        {
            
        }
        public virtual int Tuition()
        {
            return 10000;
        }
        public override string ToString()
        {
            return $"Name: {name} Id: {id} Tuition: {Tuition()}.";
        }
    }
}
