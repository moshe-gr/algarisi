using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crime
{
    class Judge
    {
        public static void numYears(Prisoner p1, Prisoner p2)
        {
            bool admit1 = p1.admit();
            bool admit2 = p2.admit();
            if (admit1 && admit2)
            {
                p1.YearsPunish = 3;
                p2.YearsPunish = 3;
            }
            else if (!admit1 && !admit2)
            {
                p1.YearsPunish = 7;
                p2.YearsPunish = 7;
            }
            else
            {
                if (admit1) {
                    p1.YearsPunish = 1;
                    p2.YearsPunish = 10;
                }
                else
                {
                    p1.YearsPunish = 10;
                    p2.YearsPunish = 1;
                }
            }
        }
    }
}
