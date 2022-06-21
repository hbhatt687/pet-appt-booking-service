using System;
using BookingService.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BookingService.Dtos
{
    public class AppointmentUpdateDto
    {
        public DateTime Date { get; set; }
        
        [JsonConverter(typeof(StringEnumConverter))]
        public AppointmentType Type { get; set; }
    }
}