using AukilaniHire.Models;

namespace AukilaniHire.Models
{
    public class Booking
    {
        public int BookingID { get; set; }
        public int MemberID { get; set; }
        public int RoomID { get; set; }

        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public Member Member { get; set; }
        public Room Room { get; set; }
    }
}