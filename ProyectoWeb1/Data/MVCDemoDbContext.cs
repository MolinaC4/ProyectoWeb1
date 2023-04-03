using Microsoft.EntityFrameworkCore;
using ProyectoWeb1.Models.Domain;

namespace ProyectoWeb1.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Medico> Medicos { get; set; }
    }
}
