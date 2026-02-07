using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortfolioHub.Domain;
using Microsoft.EntityFrameworkCore;

namespace PortfolioHub.Infrasrtructure
{
    public class CourseRepository
    {
        private readonly Context _context;

        public Context UnitOfWork
        {
            get
            {
                return _context;
            }
        }
        public CourseRepository(Context context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<List<Course>> GetAllAsync(Guid userId)
        {
            return await _context.Courses.Where(c => c.UserId == userId).OrderBy(p => p.Date).ToListAsync();
        }

        public async Task<Course> GetByIdAsync(Guid id)
        {
            return await _context.Courses.OrderBy(p => p.Date).SingleOrDefaultAsync(i => i.Id == id);
        }

        public async Task AddAsync(Course course)
        {
            _context.Courses.Add(course);
            await _context.SaveChangesAsync();
        }


    }
}
