using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BookingService.Models
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PetType 
    {
        [EnumMember(Value = "DOG")]
        Dog = 0,
        [EnumMember(Value = "CAT")]
        Cat = 1,
        [EnumMember(Value = "BIRD")]
        Bird = 2,
        [EnumMember(Value = "OTHER")]
        Other = 3
    }
}