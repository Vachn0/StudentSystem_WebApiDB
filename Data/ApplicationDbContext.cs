using StudentSystem_WebApiDB.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace StudentSystem_WebApiDB.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Student> student {get; set;}
        public DbSet<Lector> lector {get; set;}
    }
}
