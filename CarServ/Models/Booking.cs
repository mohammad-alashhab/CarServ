//using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace CarServ.Models
{
                 
    public class Booking
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        [RegularExpression(@"[A-Za-z\s]{1,100}", ErrorMessage = "Invalid name format. Please use the format: 'First Name Last Name'")]
        public string YourName { get; set; }
        [Required]
        //[EmailAddress(ErrorMessage = "Invalid Email Format")]
        [RegularExpression(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}$", ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }
        [Required]
        [RegularExpression("[A-Za-z0-9]{3,5}", ErrorMessage = "CodeDiscount has to be AA123 format ")]
        public string CodeDiscount { get; set; }
        [Required]
        [RegularExpression(@"[A-Za-z0-9\s]{1,50}", ErrorMessage = "can't be used Symbols or Numbers")]
        public string SpecialRequest { get; set; }
        [DataType(DataType.Currency)]
        public string Payment { get; set; }
        [DataType(DataType.Currency)]
        public string Car { get; set; }

        [Required]
        public string ServiceDate { get; set; }
        [Required]
        public Center Center { get; set; }
        [Required]
        public Services Service { get; set; }
    }
}
