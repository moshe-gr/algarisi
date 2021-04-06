using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crime
{
    class Court
    {
        public static int cuurentYear = 2010;
        public static Prisoner[] prisoners = new Prisoner[300];
        public static void sendToTrial()
        {
            for(int i = 0; i < prisoners.Length-1; i += 2)
            {
                if(prisoners[i] == null)
                {
                    Prisoner p1 = new Prisoner();
                    Prisoner p2 = new Prisoner();
                    Judge.numYears(p1, p2);
                    prisoners[i] = p1;
                    prisoners[i + 1] = p2;
                    break;
                }
            }
        }
        public static int NumOfPrisoners()
        {
            int numOfPrisoners = 0;
            for (int i = 0; i < prisoners.Length; i++)
            {
                if (prisoners[i] != null && prisoners[i].YearsIn < prisoners[i].YearsPunish)
                {
                    numOfPrisoners++;
                }
            }
            return numOfPrisoners;
        }
    }
}
