using System;
using Microsoft.EntityFrameworkCore;
using Unicorp.App.Dominio;

namespace Unicorp.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Personas> Persona { get; set; }
        public DbSet<Servicios> Servicio { get; set; }
        public DbSet<Pagos> Pago { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder
        )
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = UnicorpData");
            }
        }
    }
}
