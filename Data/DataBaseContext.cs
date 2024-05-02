using Microsoft.EntityFrameworkCore;
using Backend.Models;

namespace Backend.Data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Nota> Notas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);

                modelBuilder.Entity<Nota>()
                    .HasOne(n => n.categoria) // Corrige la propiedad de navegación aquí
                    .WithMany(c => c.notas) // Corrige la propiedad de navegación aquí
                    .HasForeignKey(n => n.categoria_id);
            }


    }
}
