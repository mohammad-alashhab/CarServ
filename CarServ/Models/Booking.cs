//using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace CarServ.Models
{
                 
    public class Booking
    {
        [Required(ErrorMessage = "user name cannot be Empty ")]
        [RegularExpression(@"[A-Za-z]{1,100}[ ]{1}[A-Za-z]{1,100}", ErrorMessage = "invild name should comply with Example mansoor moqbel")]
        public string YourName { get; set; }
        [Required]
        //[EmailAddress(ErrorMessage = "Invalid Email Format")]
        //[RegularExpression(@"[A-Za-z0-9]{1,100}[@]{1}[a-z]{2,9}[.]{1}[a-z]{3,5}", ErrorMessage = "Email format should comply with Example@info.com")]
        public string Email { get; set; }
        [Required]
        //[RegularExpression(@"[A-Za-z]{1,200}", ErrorMessage = "cannot be used Symbols")]
        public string SpecialRequest { get; set; }
        [Required]
        public string ServiceDate { get; set; }
        [Required]
        public Center Center { get; set; }
        [Required]
        public Services Service { get; set; }
    }
}
