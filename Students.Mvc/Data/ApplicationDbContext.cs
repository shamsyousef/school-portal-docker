using Microsoft.EntityFrameworkCore;
using Students.Mvc.Models;

namespace Students.Mvc.Data;

public class ApplicationDbContext : DbContext
{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Student> Students => Set<Student>();
}

