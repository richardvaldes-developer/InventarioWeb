
using Microsoft.EntityFrameworkCore;
using ModuloAdministrador.Models;

namespace ModuloAdministrador.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
             : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }

    }
}
