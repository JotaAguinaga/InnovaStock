using Microsoft.EntityFrameworkCore;
using ClasesInnovaStock.Models;

namespace ClasesInnovaStock.Data
{
    public class AplicationDbContext : DbContext
    {
        public DbSet<Material> Materiales { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<CargaStock> CargasStock { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=innovastock.db");
        }
    }
}