using Chatora.Services.ShoppingCartAPI.Models.Dto;

namespace Chatora.Services.ShoppingCartAPI.Service.IService;

public interface IProductService
{
    Task<IEnumerable<ProductDto>> GetProducts();
}