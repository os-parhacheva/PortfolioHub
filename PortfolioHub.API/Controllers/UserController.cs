using Microsoft.AspNetCore.Mvc;
using PortfolioHub.Domain;
using PortfolioHub.Infrasrtructure;
using PortfolioHub.API.DTO;

namespace PortfolioHub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly UserRepository _userRepository;

        public UserController(Context context)
        {
            _userRepository = new UserRepository(context);
        }


        //GET: api/User
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDTO>>> GetUsers()
        {
            var users = await _userRepository.GetAllAsync();
            List<UserDTO> userDTOs = new List<UserDTO>();
            foreach (var user in users) {
                userDTOs.Add(ToolsDTO.ConvertUserToUserDTO(user));
            }
            return userDTOs;
        }

        //Get api/User/:id
        [HttpGet("{id}")]
        public async Task<ActionResult<UserDTO>> GetUser(Guid id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            if (user == null) 
            {
                return NotFound();
            }
            return ToolsDTO.ConvertUserToUserDTO(user);
        }

        //Get api/User/:id/with-courses
        [HttpGet("{id}/with-courses")]
        public async Task<ActionResult<UserDTO>> GetUserWithCourses(Guid id)
        {
            var user = await _userRepository.GetCoursesByUserAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return ToolsDTO.ConvertUserToUserDTO(user);
        }

        // POST api/User
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
            await _userRepository.AddAsync(user);
            return Ok();
        }

        // PUT api/User/:id
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(Guid id, [FromBody] User user)
        {

            var _user = await _userRepository.GetByIdAsync(id);
            if (id != user.Id || _user == null)
            {
                return BadRequest();
            }
            await _userRepository.UpdateAsync(user);
            return NoContent();
        }

        // DELETE api/User/:id
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(Guid id)
        {
            User user = await _userRepository.GetByIdAsync(id);

            if (user == null)
            {
                return NotFound();
            }
            await _userRepository.DeleteAsync(id);
            return NoContent();
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
