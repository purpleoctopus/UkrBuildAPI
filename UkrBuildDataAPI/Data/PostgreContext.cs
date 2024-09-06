using Microsoft.EntityFrameworkCore;
using UkrBuildAPI.Shared.Models.Domain;

namespace UkrBuildDataAPI.Data
{
    public class PostgreContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Project> Projects { get; set; }
    }
}
