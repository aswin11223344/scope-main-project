using project_ScopeIndia.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
namespace project_ScopeIndia.model
{
    public class Mydbcontext:DbContext
    {
        public Mydbcontext(DbContextOptions option):base(option) { 
        
        }
        public DbSet<ScopeTable>ScopeTables { get; set; }
    }
}
