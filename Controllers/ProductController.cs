using AutoMapper;
using E_Comm.Constracts;
using E_Comm.Models;
using E_Comm.Models.DataTranferObject;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;

namespace E_Comm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CorsPolicy")]

    public class ProductController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;

        public ProductController(IRepositoryManager repositoryManager , IMapper mapper)
        {
            _mapper = mapper;
           _repository = repositoryManager;
        }

        [HttpGet]
        public IActionResult GetAllProducts(string? SearchTerm)
    {
                var product = _repository.Product.getAllProducts(SearchTerm , trackChanges: false);

                var productDTO = _mapper.Map<IEnumerable<ProductDTO>>(product);

                return Ok(productDTO);
     }
        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            var product = _repository.Product.getProductById(id , trackChanges: false);
            if(product == null)
            {
                return BadRequest("Product ID does not match !");
            }
           
            var productDto = _mapper.Map<ProductDTO>(product);
            return Ok(productDto);
            
        }
        [HttpPost]
        public IActionResult CreateProduct([FromBody] ProductCreationDTO productCreationDTO)
            {
            if (productCreationDTO == null)
            {
                return BadRequest("ProductCreationDTO object is Null");
            }
            var productDto = _mapper.Map<Product>(productCreationDTO);
            _repository.Product.create(productDto);
            _repository.Save();
            return NoContent();
            }
        //[HttpPost("{cartId}")]
        //public IActionResult CreateProductToCart(int cartId,[FromBody] ProductCreationDTO productCreationDTO)
        //{
        //    if()
        //}

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id ,[FromBody] ProductUpdateDTO productUpdateDTO )
        {
            if(productUpdateDTO == null)
            {
                return BadRequest("ProductUpdateDTO object is Null");
            }
            var productDto = _repository.Product.getProductById(id, trackChanges: true);
            if(productDto == null)
            {
                return NotFound();
            }
            _mapper.Map(productUpdateDTO, productDto);
            _repository.Save();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var product = _repository.Product.getProductById(id , trackChanges : false);
            if(product == null)
            {
                return NotFound("Product ID does not exist !");
            }
            _repository.Product.delete(product);
            _repository.Save();
            return NoContent();
        }


        
        
    
    
    }
   
}
