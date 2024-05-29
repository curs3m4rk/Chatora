using Chatora.Services.ShoppingCartAPI.Models.Dto;
using Chatora.Services.ShoppingCartAPI.Service.IService;
using Newtonsoft.Json;

namespace Chatora.Services.ShoppingCartAPI.Service;

public class CouponService : ICouponService
{
    private readonly IHttpClientFactory _httpClientFactory;

    public CouponService(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }
    public async Task<CouponDto> GetCoupon(string couponCode)
    {
        var client = _httpClientFactory.CreateClient();
        var response = await client.GetAsync($"/api/coupon/getByCode/{couponCode}");
        var apiContent = await response.Content.ReadAsStringAsync();
        var resp = JsonConvert.DeserializeObject<ResponseDto>(apiContent);
        if (resp.IsSuccess)
        {
            return JsonConvert.DeserializeObject<CouponDto>(Convert.ToString(resp.Result));
        }

        return new CouponDto();
    }
}