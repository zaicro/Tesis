using Microsoft.EntityFrameworkCore;
using System;
using TesisApi.Infraestructure.IngresosModel;
using TesisApi.Utiles;

namespace TesisApi.Infraestructure
{
    public class IngresosContext : SqlContextExtends
    {
        public IngresosContext()
            : base(GetConnectionstring())
        {
        }

        protected static String GetConnectionstring()
        {
            var configurationManager = new ConfigurationManager();
            return configurationManager.ConnectionStrings("IngresosContext");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");
        }

        public DbSet<OrdenesVenta> OrdenesVenta { get; set; }
        public DbSet<Paises> Paises { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Divisiones> Divisiones { get; set; }
        public DbSet<Bancos> Bancos { get; set; }
        public DbSet<CuentasBancarias> CuentasBancarias { get; set; }
    }
}
