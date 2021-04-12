using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyForTest
{
    class FamilyStudent: Student
    {
        public int level;
        public FamilyStudent(string name, int id) : base(name, id)
        {

        }
        public FamilyStudent(FamilyStudent student) : base(student)
        {

        }
        public override int Tuition()
        {
            if (level == 1)
            {
                return base.Tuition() / 2;
            }
            if(level == 2)
            {
                return base.Tuition() / 4;
            }
            return 0;
        }
    }
}
