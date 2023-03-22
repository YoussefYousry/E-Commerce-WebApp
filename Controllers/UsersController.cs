using E_Comm.Constracts;
using Microsoft.AspNetCore.Mvc;
using E_Comm.Models;
using AutoMapper;
using E_Comm.Models.DataTranferObject;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace E_Comm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class UsersController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        private readonly UserManager<Users> _userManager;

        public UsersController(IRepositoryManager repository, IMapper mapper , UserManager<Users> userManager)
        {
            _repository = repository;
            _mapper = mapper;
            _userManager = userManager;
        }

        [HttpGet(Name = "GetUsers") , ]//Authorize(Roles = "Admin")]
        public IActionResult GetUsers()
        {
            var userManager = _userManager.Users.ToList();

            var usersDTO = _mapper.Map<IEnumerable<UserDTO>>(userManager);

                return Ok(usersDTO);
        }


        [HttpGet("{id}")]

        public async Task <IActionResult> getUser(string id)
        {
            var userManager = await _userManager.FindByIdAsync(id);

            if (userManager == null)
            {
                return NotFound();
            }
            else
            {
                var UserDto = _mapper.Map<UserDTO>(userManager);
                return Ok(UserDto);
            }
        }
        //[HttpDelete]
        //public async Task<IActionResult> deleteUser(string id)
        //{
        //    var users = await _userManager.FindByIdAsync(id);
        //    if( users == null)
        //    {
        //        return NotFound();
        //    }
        //    _repository.

        //}








    }


    
}
