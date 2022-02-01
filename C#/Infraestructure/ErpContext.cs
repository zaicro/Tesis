using Microsoft.EntityFrameworkCore;
using System;
using TesisApi.Infraestructure.ErpModel;
using TesisApi.Utiles;

namespace TesisApi.Infraestructure
{
    public class ErpContext : SqlContextExtends
    {
        public ErpContext()
            : base(GetConnectionstring())
        {
        }

        protected static String GetConnectionstring()
        {
            var configurationManager = new ConfigurationManager();
            return configurationManager.ConnectionStrings("ErpContext");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");
        }

        public DbSet<TbDivisiones> Divisiones { get; set; }
    }
}
