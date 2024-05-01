using Microsoft.EntityFrameworkCore;
using Backend.Models;

namespace Backend.Data{
    public class DataBaseContext : DbContext{
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options){

        }

        public  DbSet<Categoria> Categorias { get; set;}
        public  DbSet<Nota> Notas { get; set;}
    }
}