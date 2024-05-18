using Microsoft.AspNetCore.Identity;

namespace Chatora.Services.AuthAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
