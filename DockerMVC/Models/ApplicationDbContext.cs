using Microsoft.EntityFrameworkCore;

namespace DockerMVC.Models
{
    public class ApplicationDbContext : DbContext
    {
        // Constructor de la clase
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Persona> Productos { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
