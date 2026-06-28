using GerenciadorBLContainer.Models;
using Microsoft.EntityFrameworkCore;

// Bruno Souza (CB3025411)
// Gabriela Wandenkolk (CB3026108)
namespace GerenciadorBLContainer
{
    public class GerenciadorBLContext : DbContext
    {
        // Este é o único construtor necessário.
        public GerenciadorBLContext(DbContextOptions<GerenciadorBLContext> options)
            : base(options)
        {
        }

        public DbSet<BL> BLs { get; set; }
        public DbSet<Container> Containers { get; set; }
    }
}
