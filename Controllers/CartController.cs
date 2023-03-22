using AutoMapper;
using E_Comm.Constracts;
using E_Comm.Models;
using E_Comm.Models.DataTranferObject;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Comm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;

        public CartController(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repositoryManager;
        }

        [HttpPost]
        public IActionResult CreateProductToCart(int cartId, [FromBody] CartItemCreationDTO cartItem)
        {
            if(cartId == null)
            {
                return NotFound("CartId does not exist");
            }
            var cartItemEntity = _mapper.Map<CartItem>(cartItem);
            cartItemEntity.CartIdFK = cartId;
            _repository.Cart.CreateCartItemToCart(cartItemEntity);
            return NoContent();
        }

        [HttpGet]
        public IActionResult GetAllCartItem()
        {
            var cartitems = _repository.Cart.getAllCartsItems(trackChanges: false);

            var cartDTO = _mapper.Map<IEnumerable<CartDTO>>(cartitems);

            return Ok(cartDTO);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var cartitem = _repository.Cart.GetCartITemById(id);
            _repository.Cart.DeleteItem(cartitem);
            _repository.Save();
            return NoContent();
        }
    }
}
