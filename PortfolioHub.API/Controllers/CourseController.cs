using Microsoft.AspNetCore.Mvc;
using PortfolioHub.API.DTO;
using PortfolioHub.API.DTO.ModelDTO;
using PortfolioHub.Domain;
using PortfolioHub.Infrasrtructure;

namespace PortfolioHub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : Controller
    {
        private readonly CourseRepository _courseRepository;
        private readonly UserRepository _userRepository;

        public CourseController(Context context)
        {
            _courseRepository = new CourseRepository(context);
            _userRepository   = new UserRepository(context);
        
        }

        //GET: api/Course/:userId/in-user
        [HttpGet("{userId}/in-user")]
        public async Task<ActionResult<IEnumerable<CourseDTO>>> GetCourses(Guid userId)
        {
            var courses = await _courseRepository.GetAllAsync(userId);
           
            List<CourseDTO>  courseDTOs = ToolsDTO.GetCoursesDTO(courses);
            
            return courseDTOs;
        }

        //Get api/Course/:courseId
        [HttpGet("{courseId}")]
        public async Task<ActionResult<CourseDTO>> GetCourse(Guid courseId)
        {
            var course = await _courseRepository.GetByIdAsync(courseId);
            if (course == null)
            {
                return NotFound();
            }
            return ToolsDTO.GetCourseDTO(course);
        }


        //POST: api/Course
        [HttpPost]
        public async Task<IActionResult> PostCourse(Course course)
        {
            var user = await _userRepository.GetByIdAsync(course.UserId);
            if (user == null)
            {
                return NotFound();                
            }
            course.User = user;
            if(course.EditBy == null)
            {
                course.EditBy = "admin";
            }
            
            await _courseRepository.AddAsync(course);
            return Ok();
        }

        // PUT api/Course/:id
        [HttpPut("{id}/update")]
        public async Task<IActionResult> PutUser(Guid id, [FromBody] Course course)
        {
            var user = await _userRepository.GetByIdAsync(course.UserId);
            if (user == null)
            {
                return NotFound();
            }
            course.User = user;

            var _course = await _courseRepository.GetByIdAsync(id);
            if (id != course.Id || _course == null)
            {
                return BadRequest();
            }
            await _courseRepository.UpdateAsync(course);
            return Ok();
        }


        // DELETE api/Course/:id
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCourse(Guid id)
        {
            Course course = await _courseRepository.GetByIdAsync(id);

            if (course == null)
            {
                return NotFound();
            }
            await _courseRepository.DeleteAsync(id);
            return Ok();
        }



        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
