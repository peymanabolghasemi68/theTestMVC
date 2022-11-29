
using Microsoft.EntityFrameworkCore;
using newCoreTraining.Mapping;
using newCoreTraining.Models;
namespace newCoreTraining
{
    public class dbSchoolContext:DbContext
    {
        public DbSet<StudentModel> dbSetStudents { get; set; }
        public DbSet<CourseModel> dbSetCourses { get; set; }
        public dbSchoolContext(DbContextOptions<dbSchoolContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentMapping());
            modelBuilder.ApplyConfiguration(new CourseMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
