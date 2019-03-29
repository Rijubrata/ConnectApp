using Microsoft.EntityFrameworkCore;
using ConnectApp.API.Models;

namespace ConnectApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
            
        }
        public DbSet<Value> Values { get; set; }
    }
}