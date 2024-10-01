
using EmployeeManagement.Model;
using Microsoft.EntityFrameworkCore;

namespace Employee.Data
{
    public class AppDbContext : DbContext
    {
        public IConfiguration _config { get; set; }
        public AppDbContext(IConfiguration config)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("DatabaseConnection"));
        }
        public DbSet<Employees> Employees { get; set; }  
    }
}
