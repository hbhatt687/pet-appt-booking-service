using System.Collections.Generic;
using BookingService.Models;
using System.Linq;
using System;

namespace BookingService.Data
{
    private readonly AppDbContext _context;

    public AppointmentRepo(AppDbContext context)
    {
        _context = context;
    }

    public class AppointmentRepo : IAppointmentRepo
    {
        public void CreateAppointment(Appointment appt)
        {
            if (appt == null)
            {
                throw new ArgumentNullException(nameof(appt));
            }

            _context.Appointments.Add(appt);
        }

        public IEnumerable<Appointment> GetAllAppointments()
        {
            return _context.Appointments.ToList();
        }

        public Appointment GetAppointmentById(int id)
        {
            return _context.Appointments.FirstOrDefault(a => a.Id == id);
        }

        public bool SaveChages()
        {
            return (_context.SaveChages() >= 0);
        }
    }
}