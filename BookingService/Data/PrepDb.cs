using System;
using System.Linq;
using BookingService.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BookingService.Data
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.CreateScope();
            SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
        }

        private static void SeedData(AppDbContext context)
        {
            if (!context.Appointments.Any())
            {
                Console.WriteLine("--> Seeding data...");
                
                context.Appointments.AddRange(
                    new Appointment { Name = "Merlin", Date = DateTime.Now.AddDays(1), Type = AppointmentType.Dental, PetType = PetType.Cat },
                    new Appointment { Name = "Pluto", Date = DateTime.Now.AddDays(3), Type = AppointmentType.Grooming, PetType = PetType.Cat },
                    new Appointment { Name = "Angel", Date = DateTime.Now.AddHours(5), Type = AppointmentType.Wellness, PetType = PetType.Dog }
                    );

                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("--> We already have data");
            }
        }
    }
}