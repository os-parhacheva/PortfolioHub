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

        public async Task DeleteAsync(Guid id)
        {
            Course сourse = await _context.Courses.FindAsync(id);
            _context.Remove(сourse);

            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Course course)
        {
            Course existCourse = await _context.Courses.SingleOrDefaultAsync(i => i.Id == course.Id);

            _context.Entry(existCourse).CurrentValues.SetValues(course);

            await _context.SaveChangesAsync();
        }



    }
}
