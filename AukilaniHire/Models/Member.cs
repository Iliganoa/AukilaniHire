using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AukilaniHire.Models
{
    public class Member
    {
        public int MemberID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }

        public string PhoneNumber { get; set; }


        public ICollection<Booking> Bookings { get; set; }
    }
}