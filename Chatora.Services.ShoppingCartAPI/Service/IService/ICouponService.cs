using Chatora.Services.ShoppingCartAPI.Models.Dto;

namespace Chatora.Services.ShoppingCartAPI.Service.IService;

public interface ICouponService
{
    Task<CouponDto> GetCoupon(string couponCode);
}