using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace EmployeeManager.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> contextOptions):base(contextOptions)
        {

        }
        public DbSet<Employee> Employees { get; set; }

    }
}
