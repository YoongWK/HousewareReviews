using Microsoft.AspNetCore.Identity;

namespace HousewareReviews.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? NRIC { get; set; }
        public string? ProfileImageUri { get; set; }
    }
}