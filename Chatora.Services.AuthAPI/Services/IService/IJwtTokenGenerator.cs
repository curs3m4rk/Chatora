using Chatora.Services.AuthAPI.Models;

namespace Chatora.Services.AuthAPI.Services.IService
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(ApplicationUser applicationUser, IEnumerable<string> roles);
    }
}
