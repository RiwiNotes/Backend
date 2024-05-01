using Microsoft.EntityFrameworkCore;

namespace Backend.Data{
    public class DataBaseContext : DbContext{
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options){

        }
        
    }
}