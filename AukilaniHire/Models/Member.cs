using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace AukilaniHire.Models
{
    public class Member
    {
        public int MemberId { get; set; }


        [Required(ErrorMessage = "Must enter Lastname"), MaxLength(20), MinLength(2)]
        [RegularExpression("^[^0-9]+$", ErrorMessage = "Invalid name.")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Must enter Name"), MaxLength(20), MinLength(2)]
        [RegularExpression("^[^0-9]+$", ErrorMessage = "Invalid name.")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Must enter Email")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$", ErrorMessage = "Invalid email")]
        public string Email { get; set; }


        [Display(Name = "Mobile Number")]
        [RegularExpression("^02[0-9]{9}$", ErrorMessage = "Invalid number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        
        public ICollection<Booking> Bookings { get; set; }
    }
}