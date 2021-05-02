using System;
using System.Linq;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Score(new int[] { 1, 2, 1, 1, 4 }));
        }
        public static int Score(int[] dice)
        {
            int sum = 0;
            for (int i = 6; i > 0; i--)
            {
                if (i == 1)
                {
                    if (Array.FindAll(dice, match => match == 1).Length > 2)
                    {
                        sum += 1000;
                    }
                    else
                    {
                        sum += Array.FindAll(dice, match => match == 1).Length * 100;
                    }
                }
                if (i == 5)
                {
                    if (Array.FindAll(dice, match => match == 5).Length <= 2)
                    {
                        sum += Array.FindAll(dice, match => match == 5).Length * 50;
                    }
                    else
                    {
                        sum += 500;
                    }
                }
                else if (i != 1 && Array.FindAll(dice, match => match == i).Length > 2)
                {
                    sum += i * 100;
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
            return sum;
        }
    }
}
