using FirmWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FirmWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Layout> Layouts { get; set; }
        public DbSet<Machine> Machines { get; set; }

    }
}
