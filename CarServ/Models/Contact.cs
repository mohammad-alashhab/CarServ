using System.ComponentModel.DataAnnotations;

namespace CarServ.Models
{
    public class Contact
    {
        [Required]
        [RegularExpression(@"^[A-Za-z]{1,50}\s[A-Za-z]{1,50}$", ErrorMessage = "Invalid name format. Please use the format: 'First Name Last Name'")]
        public string FullName { get; set; }
        [Required]
        //[EmailAddress(ErrorMessage = "Invalid Email Format")]
        [RegularExpression(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}$", ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }
        [Required]
        [RegularExpression(@"[A-Za-z]{1,50}", ErrorMessage = "cannot be used Symbols or Numbers")]
        public string Subject { get; set; }
        [Required]
        public string Message { get; set; }
    }
}
