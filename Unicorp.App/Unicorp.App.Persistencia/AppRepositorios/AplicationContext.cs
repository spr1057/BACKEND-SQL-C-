using System;
using Microsoft.EntityFrameworkCore;
using Unicorp.App.Dominio;

namespace Unicorp.Persistencia
{
    public class AplicationContext : DbContext
    {
        public DbSet<Personas> Persona { get; set; }
        public DbSet<Tecnicos> Tecnico { get; set; }
        public DbSet<Administradores> Administrador { get; set; }
        public DbSet<Clientes> Cliente { get; set; }
        public DbSet<Servicios> Servicio { get; set; }
        public DbSet<Pagos> Pago { get; set; }
        public DbSet<Detalle_de_Servicios> Detalle_Servicio { get; set; }



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
