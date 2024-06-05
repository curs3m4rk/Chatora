﻿using Chatora.Web.Models;
using Chatora.Web.Service.IService;
using Chatora.Web.Utility;

namespace Chatora.Web.Service
{
    public class OrderService : IOrderService
    {
        private readonly IBaseService _baseService;

        public OrderService(IBaseService baseService)
        {
            _baseService = baseService;
        }
        public async Task<ResponseDto?> CreateOrderAsync(CartDto cartDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.POST,
                Data = cartDto,
                Url = SD.CouponAPIBase + "/api/order/CreateOrder"
            });
        }
    }
}
