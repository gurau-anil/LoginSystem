using Microsoft.AspNetCore.Identity;

namespace LoginSystem.Entities
{
    public class ApplicationUser:IdentityUser
    {
        public string Name { get; set; }
    }
}
