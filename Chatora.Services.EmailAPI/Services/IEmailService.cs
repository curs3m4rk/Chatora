using Chatora.Services.EmailAPI.Models.Dto;

namespace Chatora.Services.EmailAPI.Services
{
    public interface IEmailService
    {
        Task EmailCartAndLog(CartDto cartDto);
    }
}
