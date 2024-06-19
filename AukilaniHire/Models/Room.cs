using AukilaniHire.Models;
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
        //[Range(0,0,ErrorMessage ="Enter valid Room Name")]
        [RegularExpression("^[^0-9]+$", ErrorMessage = "Invalid name")]
        public string RoomName { get; set; }

        [Display(Name = "Select Room")]
        public RoomType RoomType { get; set; }

        [Range(20,500,ErrorMessage ="Must enter estimate from 20-500 people")]
        [Display(Name ="People Capacity")]
        public int Capacity { get; set; }


        [MaxLength(4),MinLength(3,ErrorMessage = "Enter suitable price")]
        [DataType(DataType.Currency)]

        public decimal HireCost{ get; set; }

        public ICollection<Booking> Bookings { get; set; }
    }
}