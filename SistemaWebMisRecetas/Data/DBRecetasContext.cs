using Microsoft.EntityFrameworkCore;
using SistemaWebMisRecetas.Models;

namespace SistemaWebMisRecetas.Data
{
    public class DBRecetasContext : DbContext
    {
        public DBRecetasContext(DbContextOptions<DBRecetasContext> options) : base(options) { }

        public DbSet<Receta> Recetas { get; set; }
    }
}
