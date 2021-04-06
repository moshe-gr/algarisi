using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace inheritance
{
    class Appointment
    {
        private int timeStart;

        public int TimeStart
        {
            get { return timeStart; }
            set { timeStart = value; }
        }
        private int timeEnd;

        public int TimeEnd
        {
            get { return timeEnd; }
            set { timeEnd = value; }
        }
        private Date date = new Date();

        public Date Date
        {
            get { return date; }
            set { date = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        

    }
}