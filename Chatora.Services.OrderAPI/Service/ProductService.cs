using Chatora.Services.OrderApi.Models.Dto;
using Chatora.Services.OrderAPI.Service.IService;
using Newtonsoft.Json;

namespace Chatora.Services.OrderAPI.Service;

public class ProductService : IProductService
{
    private readonly IHttpClientFactory _httpclientFactory;

    public ProductService(IHttpClientFactory httpclientFactory)
    {
        _httpclientFactory = httpclientFactory;
    }
    
    public async Task<IEnumerable<ProductDto>> GetProducts()
    {
        var client = _httpclientFactory.CreateClient("Product");
        var response = await client.GetAsync($"/api/product");
        var apiContent = await response.Content.ReadAsStringAsync();
        var resp = JsonConvert.DeserializeObject<ResponseDto>(apiContent);
        if (resp.IsSuccess)
        {
            return JsonConvert.DeserializeObject<IEnumerable<ProductDto>>(Convert.ToString(resp.Result));
        }

        return new List<ProductDto>();
    }
}