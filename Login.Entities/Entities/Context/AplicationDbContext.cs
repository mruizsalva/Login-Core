using Login.Entities.Entities.Productos;
using Microsoft.EntityFrameworkCore;

namespace Login.Entities.Entities.Context
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Producto> Productos { get; set; }
    }
}
