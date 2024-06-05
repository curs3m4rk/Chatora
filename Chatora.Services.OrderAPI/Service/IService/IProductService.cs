
using Chatora.Services.OrderApi.Models.Dto;

namespace Chatora.Services.OrderAPI.Service.IService;

public interface IProductService
{
    Task<IEnumerable<ProductDto>> GetProducts();
}