using AutoMapper;
using E_Comm.Constracts;
using E_Comm.Models;
using E_Comm.Models.DataTranferObject;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace E_Comm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;

        public OrderController(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repositoryManager;
        }

        [HttpGet]
        public IActionResult GetOrders()
        {
            var order = _repository.Orders.getAllOrders(trackChanges: false);

            var orderDTO = _mapper.Map<IEnumerable<OrderDTO>>(order);

            return Ok(orderDTO);
        }
        [HttpPatch("{id}")]
        public IActionResult UpdateOrderStatus(int id , [FromBody] JsonPatchDocument<OrderForUpdateDTO> patchDTO)
        {
            if(patchDTO == null)
            {
                return BadRequest("UpdateDTO object is null");
            }
            var order = _repository.Orders.getOrderById(id , trackChanges : false);
            if(order == null)
            {
                return NotFound();
            }
            var orderEntity = _mapper.Map<OrderForUpdateDTO>(order);
            patchDTO.ApplyTo(orderEntity);
            _repository.Save();
            return NoContent();
        }
        [HttpPost]
        public IActionResult CreateOrderForUser([FromBody] OrderForCreationDTO orderForCreationDTO )
        {
            if(orderForCreationDTO == null)
            {
                return BadRequest();
            }
            var order = _mapper.Map<Orders>(orderForCreationDTO);
            _repository.Orders.CreateOrder(order);
            _repository.Save();
            return NoContent();

        }


    }
}
