using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BookingService.Models
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AppointmentType
    {
        [EnumMember(Value = "WELLNESS")]
        Wellness = 0,
        [EnumMember(Value = "GROOMING")]
        Grooming = 1,
        [EnumMember(Value = "SURGERY")]
        Surgery = 2,
        [EnumMember(Value = "DENTAL")]
        Dental = 3,
        [EnumMember(Value = "OTHER")]
        Other = 4
    }
}