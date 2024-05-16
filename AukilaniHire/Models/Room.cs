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
        [Required(ErrorMessage ="Enter valid Room Name")]
        public string RoomName { get; set; }

        [Display(Name = "Room Type")]
        public RoomType RoomType { get; set; }

        [Range(20,500,ErrorMessage ="Must enter estimate from 20-500 people")]
        [Display(Name ="People Capacity")]
        public int Capacity { get; set; }


        // [MaxLength(7),MinLength(2,ErrorMessage = "Enter suitable price")]
        [DataType(DataType.Currency)]
        public decimal HireCost{ get; set; }

        public ICollection<Booking> Bookings { get; set; }
    }
}