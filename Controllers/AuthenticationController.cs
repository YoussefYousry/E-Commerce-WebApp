using AutoMapper;
using E_Comm.Constracts;
using E_Comm.Models;
using E_Comm.Models.DataTranferObject;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace E_Comm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly UserManager<Users> _userManager;
        private readonly IAuthenticationManager _authManager;
        private readonly IRepositoryManager _repository;
        public AuthenticationController(IMapper mapper, UserManager<Users> userManager , 
            IAuthenticationManager authenticationManager , IRepositoryManager repositoryManager)
        {
            _repository = repositoryManager;
            _mapper = mapper;
            _userManager = userManager;
            _authManager = authenticationManager;

        }

        [HttpPost]
        public async Task<IActionResult> RegisterUser([FromBody] UserRegistrationDTO userRegistrationDTO)
        {
            var user = _mapper.Map<Users>(userRegistrationDTO);

            var result = await _userManager.CreateAsync(user, userRegistrationDTO.Password);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }
                return BadRequest();
            }
            await _userManager.AddToRolesAsync(user, userRegistrationDTO.Roles);

            return StatusCode(201);
        }

        [HttpPut("{username}")]
        public async Task<IActionResult> UpdateUser(string username , [FromBody] UserUpdateDTO userUpdateDTO)
        {
            var userEntity = await _userManager.FindByNameAsync(username);

            if (userEntity == null)
            {
                return BadRequest();
            }
            _mapper.Map(userEntity,userUpdateDTO);

            var result = await _userManager.UpdateAsync(userEntity);
            _repository.Save();
            
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }
                return BadRequest();
            }
            
            return StatusCode(201);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Authenticate([FromBody] UserAuthenticationDTO user)
        {
            if(!await _authManager.ValidateUser(user))
            {
                return Unauthorized();
            }
            return Ok(new { Token = await _authManager.CreateToken()});
        }
    }
}
