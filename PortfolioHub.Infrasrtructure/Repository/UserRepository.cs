using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortfolioHub.Domain;
using Microsoft.EntityFrameworkCore;

namespace PortfolioHub.Infrasrtructure
{
    public class UserRepository
    {
        private readonly Context _context;

        public Context UnitOfWork
        {
            get
            {
                return _context;
            }
        }
        public UserRepository(Context context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<List<User>> GetAllAsync()
        {  
            return await _context.Users.OrderBy(p => p.FirstName).ToListAsync();
        }

        public async Task<User> GetByIdAsync(Guid id)
        {
            return await _context.Users.OrderBy(p => p.FirstName).SingleOrDefaultAsync(i => i.Id == id);
        }

        public async Task<List<Competition>> GetCompetitionsByUserAsync(Guid userId)
        {
            return await _context.Competitions
                .Where(c => c.UserId == userId)
                .Include(c => c.Stages)
                    .ThenInclude(s => s.Participants)
                .ToListAsync();
        }

        public async Task<List<Publication>> GetPublicationsByUserAsync(Guid userId)
        {
            return await _context.Publications
                .Where(p => p.UserId == userId)
                .Include(p => p.Authors)
                .ToListAsync();
        }

        public async Task<List<Course>> GetCoursesByUserAsync(Guid userId)
        {
            return await _context.Courses
                .Where(c => c.UserId == userId)                
                .ToListAsync();
        }

        public async Task AddAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(User user)
        {
           /* var existUser = await _context.Users.SingleOrDefaultAsync(i => i.Id == user.Id);
            _context.Entry(existUser).CurrentValues.SetValues(user);*/

            _context.Users.Update(user);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            User user = await _context.Users.FindAsync(id);
            _context.Remove(user);

            await _context.SaveChangesAsync();
        }

        public void ChangeTrackerClear()
        {
            _context.ChangeTracker.Clear();
        }

    }
}
