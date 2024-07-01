using AukilaniHire.Models;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AukilaniHire.Models
{

    public enum RoomType
    {
        Function, Auditorium, Meeting
    }
    public class Room
    {
        public int RoomId { get; set; }

        [Display(Name ="Room Name")]
        [RegularExpression("^[^0-9]+$", ErrorMessage = "Invalid name")]
        [Required(ErrorMessage = "Must enter name")]
        public string RoomName { get; set; }

        [Display(Name = "Select Room")]
        public RoomType RoomType { get; set; }

        [Range(20,500,ErrorMessage ="Estimate From 20-500 People")]
        [Display(Name ="People Capacity")]
        [Required(ErrorMessage = "Must enter the amount of people")]
        public int Capacity { get; set; }


        //[MaxLength(4),MinLength(3,ErrorMessage = "Enter Suitable Price")]
        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Must enter apropriate amount")]
        public decimal HireCost{ get; set; }

        public ICollection<Booking> Bookings { get; set; }
    }
}