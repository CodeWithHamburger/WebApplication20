using Microsoft.EntityFrameworkCore;
using WebApplication20.Models;

namespace WebApplication20.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> contextOptions) 
            : base(contextOptions)  
        {
            
        }  

        //
        public DbSet<Employee> Employees { get; set; }
    }
}
