using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Date
    {
        private int day;
        private int month;
        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }


        public int Month
        {
            get { return month; }
            set { if(value > 0 && value <= 12) month = value; }
        }


        public int Day
        {
            get { return day; }
            set { if(value > 0 && value < 31) day = value; }
        }
        public Date()
        {

        }
        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        public override string ToString()
        {
            return string.Format("{0}/{1}/{2}", day, month, year);
        }

    }
}
