using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PortfolioHub.Domain;

namespace PortfolioHub.Infrasrtructure
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
       : base(options)
        {
        }

/*        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Achievement>().UseTpcMappingStrategy();  // Используем стратегию TPC
        }*/



        // Пользователи
        public DbSet<User> Users { get; set; }

        // Достижения
        public DbSet<Competition> Competitions { get; set; }
        public DbSet<Stage> Stages { get; set; }
        public DbSet<Publication> Publications { get; set; }
        public DbSet<Conference> Conferences { get; set; }
        public DbSet<Course> Courses { get; set; }

        // Люди
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Author> Authors { get; set; }

    }
}
