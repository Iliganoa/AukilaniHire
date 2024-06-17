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


        [Required(ErrorMessage = "Must enter Lastname"), MaxLength(30)]
        [RegularExpression("/([0-9])",ErrorMessage = "Name is not valid.")]
        
        public string LastName { get; set; }


        [Required(ErrorMessage = "Must enter Name"), MaxLength(30)]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Must enter Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required(ErrorMessage = "Must enter Mobile number")]
        [Display(Name = "Contact Number")]
        [MaxLength(20)]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        
        public ICollection<Booking> Bookings { get; set; }
    }
}