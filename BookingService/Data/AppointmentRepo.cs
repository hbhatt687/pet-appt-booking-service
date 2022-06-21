using System.Collections.Generic;
using BookingService.Models;
using System.Linq;
using System;

namespace BookingService.Data
{
    public class AppointmentRepo : IAppointmentRepo
    {
        private readonly AppDbContext _context;

        public AppointmentRepo(AppDbContext context)
        {
            _context = context;
        }
        
        public void CreateAppointment(Appointment appt)
        {
            if (appt == null)
            {
                throw new ArgumentNullException(nameof(appt));
            }

            _context.Appointments.Add(appt);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public IEnumerable<Appointment> GetAllAppointments()
        {
            return _context.Appointments.ToList();
        }

        public Appointment GetAppointmentById(int id)
        {
            return _context.Appointments.FirstOrDefault(a => a.Id == id);
        }

        public void UpdateAppointment(Appointment appt)
        {
            if (appt == null)
            {
                throw new ArgumentNullException(nameof(appt));
            }

            _context.Appointments.Update(appt);
        }
    }
}