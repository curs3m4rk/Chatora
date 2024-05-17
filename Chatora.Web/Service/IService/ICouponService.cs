using Chatora.Web.Models;

namespace Chatora.Web.Service.IService;

public interface ICouponService
{
    Task<ResponseDto?> GetAllCouponsAsync();
    Task<ResponseDto?> GetCouponAsync(string couponCode);
    Task<ResponseDto?> GetCouponByIdAsync(int id);
    Task<ResponseDto?> CreateCouponsAsync(CouponDto couponDto);
    Task<ResponseDto?> UpdateCouponsAsync(CouponDto couponDto);
    Task<ResponseDto?> DeleteCouponsAsync(int id);
}