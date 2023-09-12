using Microsoft.AspNetCore.Identity;

namespace CarServ.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public bool IsAdmin { get; set; }
    }
}
