using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewApp
{
    class OutOfRangeExeption : Exception
    {
        public override string Message => "Index out of range please try again";
    }
}
