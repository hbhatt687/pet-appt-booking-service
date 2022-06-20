using System;
using System.ComponentModel.DataAnnotations;
using BookingService.Models;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace BookingService.Dtos
{
    public class AppointmentCreateDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [JsonConverter(typeof(StringEnumConverter))]
        public PetType PetType { get; set; }

        public DateTime Date { get; set; }

        [Required]
        [JsonConverter(typeof(StringEnumConverter))]
        public AppointmentType Type { get; set; }
    }
}