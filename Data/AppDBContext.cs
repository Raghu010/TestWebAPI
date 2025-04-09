using Microsoft.EntityFrameworkCore;
using SdaemonAPIProject.Model.Entities;

namespace SdaemonAPIProject.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
                
        }

        public DbSet<CreateEF> creates { get; set; }
    }
}
