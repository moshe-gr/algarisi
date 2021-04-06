using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace inheritance
{
    class AppointmentHandle: Appointment
    {
        private static List<Appointment> appointments = new List<Appointment>();

        public static void CreateAppointment()
        {
            Appointment appoint = new Appointment();
            Console.WriteLine("Enter your name: ");
            appoint.Name = Console.ReadLine();
            Console.WriteLine("Choose date: ");
            string date = Console.ReadLine();
            appoint.Date.Day = int.Parse(date.Split("/")[0]);
            appoint.Date.Month = int.Parse(date.Split("/")[1]);
            appoint.Date.Year = int.Parse(date.Split("/")[2]);
            Console.WriteLine("Choose time: ");
            appoint.TimeStart = int.Parse(Console.ReadLine());
            if(appointments.Exists(ap => appoint.Date.Year == ap.Date.Year && appoint.Date.Month == ap.Date.Month && appoint.Date.Day == ap.Date.Day && appoint.TimeStart == ap.TimeStart))
            {
                Console.WriteLine("Appointment allready exists");
                CreateAppointment();        
            }
            else
            {
                appointments.Add(appoint);
                Console.WriteLine(appoint);
            }
            
        }
        public static void CancelAppointment()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            List<Appointment> myAppointments = appointments.FindAll(ap => ap.Name == name);
            for (int i = 0; i < myAppointments.Count; i++)
            {
                Console.WriteLine(i + 1 + ": " + myAppointments[i]);
            }
            Console.WriteLine("Choose appointment to cancel: ");
            appointments.Remove(myAppointments[int.Parse(Console.ReadLine()) - 1]);
            Console.WriteLine("Appointment canceld");
        }
        public override string ToString()
        {
            return string.Format("{0} your appointment set to {1} at {2}", Name, Date, TimeStart);
        }

    }
}