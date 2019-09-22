

using System.Data.Entity;

namespace DotnetCoreTest
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("Davidian") =>
         Database.SetInitializer<SchoolContext>(new SchoolDBInitializer());

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Adds configurations for Student from separate class
            modelBuilder.Configurations.Add(new StudentConfigurations());

            modelBuilder.Entity<Teacher>()
                .ToTable("TeacherInfo");



            modelBuilder.Entity<Teacher>().MapToStoredProcedures();
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Produce> Produce { get; set; }

        public DbSet<Grade> Grades { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentAddress> StudentAddresses { get; set; }
    }
}