using AutoMapper;
using Chatora.Services.ShoppingCartAPI.Data;
using Chatora.Services.ShoppingCartAPI.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Chatora.Services.ShoppingCartAPI.Controllers
{
    [Route("api/cart")]
    [ApiController]
    public class CartAPIController : ControllerBase
    {
        private ApplicationDbContext _db;
        private IMapper _mapper;
        private ResponseDto _response;

        public CartAPIController(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _response = new ResponseDto();
        }
        
        [HttpPost("CartUpsert")]
        public async Task<ResponseDto> CartUpsert(CartDto cartDto)
        {
            
        }
    }
}
