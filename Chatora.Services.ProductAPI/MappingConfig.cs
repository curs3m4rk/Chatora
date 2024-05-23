using AutoMapper;
using Chatora.Services.ProductAPI.Models;
using Chatora.Services.ProductAPI.Models.Dto;

namespace Chatora.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
