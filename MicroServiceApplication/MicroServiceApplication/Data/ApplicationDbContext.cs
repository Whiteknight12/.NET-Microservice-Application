using MicroServiceApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroServiceApplication.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<Platform> Platforms { get; set; }
    }
}
