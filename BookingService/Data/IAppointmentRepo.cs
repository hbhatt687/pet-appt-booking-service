using System.Collections.Generic;
using BookingService.Models;

namespace BookingService.Data
{
    public interface IAppointmentRepo
    {
        bool SaveChanges();

        IEnumerable<Appointment> GetAllAppointments();

        Appointment GetAppointmentById(int id);

        void CreateAppointment(Appointment appt);
        void UpdateAppointment(Appointment appt);
    }
}