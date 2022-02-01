using Microsoft.EntityFrameworkCore;
using System;
using TesisApi.Infraestructure.PeachtreeModel;
using TesisApi.Utiles;

namespace TesisApi.Infraestructure
{
    public class PeachtreeContext : SqlContextExtends
    {
        public PeachtreeContext()
            : base(GetConnectionstring())
        {
        }

        protected static String GetConnectionstring()
        {
            var configurationManager = new ConfigurationManager();
            return configurationManager.ConnectionStrings("PeachtreeContext");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");
        }

        public DbSet<TbOrdenesDeVentaTest> OrdenesDeVenta { get; set; }
        public DbSet<TbPaises> Paises { get; set; }
        public DbSet<ClientesTest> Clientes { get; set; }
        public DbSet<TbDicBancos> DicBancos { get; set; }
        public DbSet<TbCuentasBancarias> CuentasBancarias { get; set; }
    }
}
