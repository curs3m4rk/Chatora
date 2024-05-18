using Chatora.Services.AuthAPI.Models.Dto;
using Chatora.Services.AuthAPI.Services.IService;
using Microsoft.AspNetCore.Mvc;

namespace Chatora.Services.AuthAPI.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthAPIController : Controller
    {
        private ResponseDto _response;
        private IAuthService _authService;

        public AuthAPIController(IAuthService authService)
        {
            _response = new ResponseDto();
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegistrationRequestDto model)
        {
            var errorMessage = await _authService.Register(model);

            if(!string.IsNullOrEmpty(errorMessage))
            {
                _response.IsSuccess = false;
                _response.Message = errorMessage;
                return BadRequest(_response);
            }
            return Ok(_response);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login()
        {
            return Ok();
        }
    }
}
