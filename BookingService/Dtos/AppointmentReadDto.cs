using System;
using BookingService.Models;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace BookingService.Dtos
{
    public class AppointmentReadDto
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        [JsonConverter(typeof(StringEnumConverter))]
        public PetType PetType { get; set; }

        public DateTime Date { get; set; }
        
        [JsonConverter(typeof(StringEnumConverter))]
        public AppointmentType Type { get; set; }
    }
}