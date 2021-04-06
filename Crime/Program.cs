using System;

namespace Crime
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < Court.prisoners.Length/2; i++)
            {
                Court.sendToTrial();
                if(i != 0 && i % 20 == 0)
                {
                    Court.cuurentYear++;
                }
            }
            foreach(Prisoner p in Court.prisoners)
            {
                if(p == null)
                {
                    break;
                }
                Console.WriteLine(p);
            }
            Console.WriteLine(Court.NumOfPrisoners());
        }
    }
}
