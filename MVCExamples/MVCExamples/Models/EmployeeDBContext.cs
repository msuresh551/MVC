using System.Data.Entity;

namespace MVCExamples.Models
{
    public class EmployeeDBContext:DbContext
    {
        public DbSet<EnitityClass> employees { get; set; }
    }
}