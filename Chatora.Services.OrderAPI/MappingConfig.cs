using AutoMapper;
using Chatora.Services.OrderApi.Models.Dto;
using Chatora.Services.OrderAPI.Models;
using Chatora.Services.OrderAPI.Models.Dto;

namespace Chatora.Services.OrderAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<OrderHeaderDto, CartHeaderDto>()
                .ForMember(dest => dest.CartTotal, x => x.MapFrom(src => src.OrderTotal)).ReverseMap();

                config.CreateMap<CartDetailsDto, OrderDetailsDto>()
                .ForMember(dest => dest.ProductName, x => x.MapFrom(src => src.Product.Name));

                config.CreateMap<CartDetailsDto, OrderDetailsDto>()
                .ForMember(dest => dest.Price, x => x.MapFrom(src => src.Product.Price));

                config.CreateMap<OrderHeader, OrderHeaderDto>().ReverseMap();
                config.CreateMap<OrderDetails, OrderDetailsDto>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
