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

        public CourseController(Context context)
        {
            _courseRepository = new CourseRepository(context);
        }

        //GET: api/Course/:userId
        [HttpGet("{userId}")]
        public async Task<ActionResult<IEnumerable<CourseDTO>>> GetCourses(Guid userId)
        {
            var courses = await _courseRepository.GetAllAsync(userId);
           
            List<CourseDTO>  courseDTOs = ToolsDTO.GetCoursesDTO(courses);
            
            return courseDTOs;
        }


        //POST: api/Course
        [HttpPost]
        public async Task<IActionResult> PostCourse(Course course)
        {
            await _courseRepository.AddAsync(course);
            return Ok();
        }



        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
