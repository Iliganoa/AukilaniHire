using AukilaniHire.Models;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace AukilaniHire.Models
{

    public class Booking
    {
        public int BookingId { get; set; }

        public int MemberId { get; set; }
        public Member Member { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }



        [Required(ErrorMessage = "Enter valid Booking date")]
        [DataType(DataType.Date)]
        public DateOnly BeginDate { get; set; }

        [Required(ErrorMessage = "Enter valid Booking date")]
        [DataType(DataType.Date)]
        public DateOnly EndDate { get; set; }

        [Required(ErrorMessage = "Enter valid Booking time")]
        [DataType(DataType.Time)]
        public TimeOnly BeginTime { get; set; }

        [Required(ErrorMessage = "Enter valid Booking time")]
        [DataType(DataType.Time)]
        public TimeOnly EndTime { get; set; }
        
    }
}