using Chatora.Services.AuthAPI.Data;
using Chatora.Services.AuthAPI.Models;
using Chatora.Services.AuthAPI.Models.Dto;
using Chatora.Services.AuthAPI.Services.IService;
using Microsoft.AspNetCore.Identity;

namespace Chatora.Services.AuthAPI.Services
{
    public class AuthService : IAuthService
    {
        private readonly ApplicationDbContext _db;
        // below 2 dependecy injection are used to insert data automatically in Identity Tables
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AuthService(ApplicationDbContext db, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public Task<LoginResponseDto> Login(LoginRequestDto loginRequestDto)
        {
            throw new NotImplementedException();
        }

        public Task<UserDto> Register(RegistrationRequestDto registrationRequestDto)
        {
            throw new NotImplementedException();
        }
    }
}
