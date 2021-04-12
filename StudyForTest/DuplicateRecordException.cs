using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyForTest
{
    class DuplicateRecordException: Exception
    {
        public override string Message => "Id alredy exists";
    }
}
