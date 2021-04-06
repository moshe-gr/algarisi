using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace Crime
{
    class Prisoner
    {
        Person person;
        private int yearsPunish;

        public int YearsPunish
        {
            get { return yearsPunish; }
            set { yearsPunish = value; }
        }
        private int yearStart;

        public int YearStart
        {
            get { return yearStart; }
            set { yearStart = value; }
        }
        private int yearsIn;

        public int YearsIn
        {
            get { return yearsIn; }
            set { 
                if(value < YearsPunish)
                {
                    yearsIn = value;
                }
                else
                {
                    yearsIn = YearsPunish;
                }
                 }
        }
        public Prisoner()
        {
            person = new Person();
            YearStart = Court.cuurentYear;
        }
        public bool admit()
        {
            return new Random().Next(0, 2) == 1;
        }
        public override string ToString()
        {
            YearsIn = DateTime.Now.Year - YearStart;
            return string.Format("Name: {4}, last name: {5}.\nPunishment: {0}, year start: {1}, years in: {2}, years left: {3}.\n", YearsPunish, YearStart, YearsIn, YearsPunish - YearsIn, person.name, person.lastName);
        }


    }
}
