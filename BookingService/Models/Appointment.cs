using PetType;
using AppointmentType;
using System.ComponentModel.DataAnnotations;


public class Appointment
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    [EnumDataType(typeof(PetType))]
    public PetType PetType { get; set; }

    public DateTime Date { get; set; }

    [Required]
    [EnumDataType(typeof(AppointmentType))]
    public AppointmentType Type { get; set; }
}