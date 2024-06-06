using Chatora.Web.Models;

namespace Chatora.Web.Service.IService
{
    public interface IOrderService
    {
        Task<ResponseDto?> CreateOrderAsync(CartDto cartDto);
        Task<ResponseDto?> CreateStripeSession(StripeRequestDto stripeRequestDto);
        Task<ResponseDto?> ValidateStripeSession(int orderHeaderId);
    }
}
