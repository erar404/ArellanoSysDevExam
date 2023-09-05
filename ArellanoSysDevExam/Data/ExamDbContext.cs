using ArellanoSysDevExam.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace ArellanoSysDevExam.Data
{
    public class ExamDbContext : DbContext
    {
        public ExamDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Branch> Branches { get; set; }
    }

}
