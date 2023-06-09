using Microsoft.EntityFrameworkCore;

namespace School.Models
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: "Data Source=.;Initial Catalog=School;Integrated Security=True");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
