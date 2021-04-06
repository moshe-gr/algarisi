using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            AppointmentHandle.CreateAppointment();
            AppointmentHandle.CreateAppointment();
            AppointmentHandle.CreateAppointment();
            AppointmentHandle.CreateAppointment();
            AppointmentHandle.CancelAppointment();
            AppointmentHandle.CreateAppointment();
            AppointmentHandle.CreateAppointment();
            AppointmentHandle.CancelAppointment();
            AppointmentHandle.CreateAppointment();
        }
    }
}