using System;
using System.Collections;
using System.Collections.Generic;
using AutoMapper;
using BookingService.Data;
using BookingService.Dtos;
using BookingService.Models;
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
            var appointmentItems = _repository.GetAllAppointments();

            return Ok(_mapper.Map<IEnumerable<AppointmentReadDto>>(appointmentItems));
        }

        [HttpGet("{id:int}", Name = "GetAppointmentById")]
        public ActionResult<AppointmentReadDto> GetAppointmentById(int id)
        {
            var appointmentItem = _repository.GetAppointmentById(id);

            if (appointmentItem == null)
            {
                NotFound();
            }

            return Ok(_mapper.Map<AppointmentReadDto>(appointmentItem));
        }

        [HttpPost]
        public ActionResult<AppointmentReadDto> CreateAppointment(AppointmentCreateDto appointmentCreateDto)
        {
            var appointmentModel = _mapper.Map<Appointment>(appointmentCreateDto);
            _repository.CreateAppointment(appointmentModel);
            _repository.SaveChanges();

            var appointmentReadDto = _mapper.Map<AppointmentReadDto>(appointmentModel);

            return CreatedAtRoute(nameof(GetAppointmentById), new { Id = appointmentReadDto.Id }, appointmentReadDto);
        }

        [HttpPut("{id:int}")]
        public ActionResult<AppointmentReadDto> UpdateAppointment(AppointmentUpdateDto appointmentUpdateDto, int id)
        {
            var existingAppointment = _repository.GetAppointmentById(id);

            if (existingAppointment == null)
            {
                return NotFound();
            }

            existingAppointment.Date = appointmentUpdateDto.Date;
            existingAppointment.Type = appointmentUpdateDto.Type;
            
            _repository.UpdateAppointment(existingAppointment);
            _repository.SaveChanges();

            return Ok(_mapper.Map<AppointmentReadDto>(existingAppointment));
        }

        [HttpDelete("{id:int}")]
        public ActionResult CancelAppointment(int id)
        {
            var existingAppointment = _repository.GetAppointmentById(id);

            if (existingAppointment == null)
            {
                return NotFound();
            }
            
            _repository.CancelAppointment(id);
            _repository.SaveChanges();

            return NoContent();
        }
    }
}