using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyForTest
{
    class University
    {
        public string name;
        public int num_of_student;
        public List<Student> students = new List<Student>();
        public University(string name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return $"University of {name}.";
        }
    }
}
