using System;
using System.Collections;
using System.Collections.Generic;
using AutoMapper;
using BookingService.Data;
using BookingService.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace BookingService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentsController : ControllerBase
    {
        private readonly IAppointmentRepo _repository;
        private readonly IMapper _mapper;

        public AppointmentsController(IAppointmentRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<AppointmentReadDto>> GetAppointments()
        {
            Console.WriteLine("--> Getting appointments...");
            var appointmentItems = _repository.GetAllAppointments();

            return Ok(_mapper.Map<IEnumerable<AppointmentReadDto>>(appointmentItems));
        }
    }
}