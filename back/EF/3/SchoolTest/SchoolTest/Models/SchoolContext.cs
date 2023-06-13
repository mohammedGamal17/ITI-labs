using Microsoft.EntityFrameworkCore;
using SchoolTest.Models;

namespace School.Models
{
    public class SchoolContext : DbContext
    {
        #region Constructors
        public SchoolContext() { }

        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options) { }
        #endregion


        #region Prop
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Department> Departments { get; set; }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<DepartmentsCourses> DepartmentsCourses { get; set; }
        public virtual DbSet<StudentsCourses> StudentsCourses { get; set; }
        #endregion


        #region OnConfig
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            base.OnConfiguring(optionsBuilder);
        }
        #endregion


        #region OnModel
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Course

            modelBuilder.Entity<Course>(
    c =>
    {
        c.HasKey(pk => pk.ID);
        c.Property<string>(name => name.Name).IsRequired();
        c.Property<string>(desc => desc.Description).IsRequired();
        c.Property<int>(dur => dur.Duration).IsRequired();
    });
            #endregion

            #region DepartmentsCourses

            modelBuilder.Entity<DepartmentsCourses>(deptCors =>
            {
                deptCors.HasKey(pk => new { pk.DeptID, pk.CursID });

            });

            #endregion

            #region StudentsCourses

            modelBuilder.Entity<StudentsCourses>(stdCors =>
            {
                stdCors.HasKey(pk => new { pk.StdId, pk.CursID });
            });

            #endregion

            #region Student

            modelBuilder.Entity<Student>(
student =>
{
    student.HasKey(i => i.ID);
    student.Property<string>(n => n.Name)
    .IsRequired();

    student.Property<string>(n => n.Email)
    .IsRequired();


    student.Property<int>(n => n.Age);
});

            #endregion

            base.OnModelCreating(modelBuilder);
        }

        #endregion

    }
}
