﻿//using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace CarServ.Models
{
                 
    public class Booking
    {
        [Required]
        [RegularExpression(@"^[A-Za-z]{1,50}\s[A-Za-z]{1,50}$", ErrorMessage = "Invalid name format. Please use the format: 'First Name Last Name'")]
        public string YourName { get; set; }
        [Required]
        //[EmailAddress(ErrorMessage = "Invalid Email Format")]
        [RegularExpression(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}$", ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }
        [Required]
        [RegularExpression(@"[A-Za-z]{1,50}", ErrorMessage = "cannot be used Symbols")]
        public string SpecialRequest { get; set; }
        [Required]
        public string ServiceDate { get; set; }
        [Required]
        public Center Center { get; set; }
        [Required]
        public Services Service { get; set; }
    }
}