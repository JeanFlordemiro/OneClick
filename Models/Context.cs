using Microsoft.EntityFrameworkCore;

namespace OneClick.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) {
        }

        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Viagens> Viagens { get; set;}
    }
}
