using Microsoft.AspNetCore.Identity;

namespace IdentityWithRazorPages.Models
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public byte[]? ProfilePicture { get; set; }
    }
}
