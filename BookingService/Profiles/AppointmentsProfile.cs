using AutoMapper;
using BookingService.Dtos;
using BookingService.Models;

namespace BookingService.Profiles
{
    public class AppointmentsProfile : Profile
    {
        public AppointmentsProfile()
        {
            // Source -> Target
            CreateMap<Appointment, AppointmentReadDto>();
            CreateMap<AppointmentCreateDto, Appointment>();
            CreateMap<AppointmentUpdateDto, Appointment>();
            CreateMap<Appointment, AppointmentUpdateDto>();
        }
    }
}