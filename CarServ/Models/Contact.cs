using System.ComponentModel.DataAnnotations;

namespace CarServ.Models
{
    public class Contact
    {
        [Required]
        [RegularExpression(@"[A-Za-z\s]{1,100}", ErrorMessage = "Invalid name format. Please use the format: 'First Name Last Name'")]
        public string FullName { get; set; }
        [Required]
        //[EmailAddress(ErrorMessage = "Invalid Email Format")]
        [RegularExpression(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}$", ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }
        [Required]
        [RegularExpression(@"[A-Za-z]{1,50}", ErrorMessage = "can't be used Symbols or Numbers")]
        public string Subject { get; set; }
        [Required]
        [RegularExpression(@"[A-Za-z0-9\s]{1,500}", ErrorMessage = "Message Should Be Under 500 Charaters and can't be use Symbols")]
        public string Message { get; set; }
    }
}
