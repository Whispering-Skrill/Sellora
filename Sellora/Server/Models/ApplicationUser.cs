using Microsoft.AspNetCore.Identity;

namespace Sellora.Server.Models
{
    // The is entity config page edits the attributes within the ApplicationUser Table (Login and Registration details)
    public class ApplicationUser : IdentityUser
    {
        public string? UserFirstName { get; set; }
        public string? UserLastName { get; set;}
        public DateTime UserRegDate { get;set; }
        public string? UserDescription { get; set; }
        public DateTime UserLastOnline { get; set; }
    }
}
