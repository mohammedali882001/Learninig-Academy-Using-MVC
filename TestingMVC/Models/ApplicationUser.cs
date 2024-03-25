using Microsoft.AspNetCore.Identity;

namespace TestingMVC.Models
{
    public class ApplicationUser : IdentityUser
    {
       
        public string Address { get; set; }
    }
}
