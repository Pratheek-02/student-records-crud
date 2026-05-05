using Microsoft.EntityFrameworkCore;

namespace OurProject.Models
{
    public class StudentDBContext : DbContext
    {
        public StudentDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
               "Server=localhost\\SQLEXPRESS;Database=studentData;Trusted_Connection=True;TrustServerCertificate=True;"
           );
        }
    }
}
