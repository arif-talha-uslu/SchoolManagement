using Microsoft.EntityFrameworkCore;
using SchoolManagement.Models.Entities;

namespace SchoolManagement.Models.Contexts
{
    public class SchoolContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Initial Catalog=SchoolDb;Integrated Security=true");
        }
    }
}
