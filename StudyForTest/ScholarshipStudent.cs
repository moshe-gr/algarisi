using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyForTest
{
    class ScholarshipStudent: Student
    {
        public int scholarship_sum;
        public ScholarshipStudent(string name, int id) : base(name, id)
        {
            
        }
        public ScholarshipStudent(ScholarshipStudent student): base(student)
        {
                
        }
        public override int Tuition()
        {
            return base.Tuition() - scholarship_sum;
        }
    }
}
