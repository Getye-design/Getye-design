using System.Data.Entity;

namespace EFCodeFirstMSSQL
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("StudentDB") { } // Refers to App.config connection string

        public DbSet<Student> Students { get; set; }
    }
}
