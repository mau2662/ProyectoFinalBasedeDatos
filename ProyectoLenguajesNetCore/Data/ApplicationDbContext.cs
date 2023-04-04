using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProyectoLenguajesNetCore.Models;

namespace ProyectoLenguajesNetCore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ProyectoLenguajesNetCore.Models.CLIENTE>? Client { get; set; }
        public DbSet<ProyectoLenguajesNetCore.Models.MEDICAMENTO>? MEDICAMENTO { get; set; }
        public DbSet<ProyectoLenguajesNetCore.Models.ALMACEN>? ALMACEN { get; set; }
        public DbSet<ProyectoLenguajesNetCore.Models.FACTURA>? FACTURA { get; set; }
    }
}