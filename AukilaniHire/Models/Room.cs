using AukilaniHire.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AukilaniHire.Models
{

    public enum RoomType
    {
        Function, Auditorium, Meeting
    }
    public class Room
    {
        
        public int RoomID { get; set; }
        public RoomType RoomType { get; set; }
        public int Capacity { get; set; }
        public decimal HireCost{ get; set; }

        public ICollection<Booking> Booking { get; set; }
    }
}