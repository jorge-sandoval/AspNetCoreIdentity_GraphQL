using Microsoft.AspNetCore.Identity;

namespace AspNetCore.Identity.Data
{
    public class User : IdentityUser
    {
        public string? Initials { get; set; }
    }
}
