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
        public string RoomName { get; set; }
        public int RoomId { get; set; }
        public RoomType RoomType { get; set; }

        [Range(20,500,ErrorMessage ="Must enter correct estimate")]
        [Display(Name ="People capacity")]
        public int Capacity { get; set; }

       // [DataType(DataType.Currency)]
       // [MaxLength(7),MinLength(2,ErrorMessage = "Enter suitable price")]
        public decimal HireCost{ get; set; }

        public ICollection<Booking> Bookings { get; set; }
    }
}