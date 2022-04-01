using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class Conexion : DbContext
    {
        public Conexion(DbContextOptions<Conexion> options) : base(options)
        {
            
        }

        public DbSet<User> Usuario { get; set; }
    }
}
