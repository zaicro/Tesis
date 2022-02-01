using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using TesisApi.Infraestructure;
using TesisApi.Infraestructure.IngresosModel;
using TesisApi.Infraestructure.PeachtreeModel;

namespace TesisApi.Controllers
{
    [Route("api/v1/[controller]")]
    public class SincronizarController : ControllerBase
    {
        [Route("Paises")]
        [HttpPost]
        public IActionResult PostPaises()
        {
            var paises = new List<TbPaises>();
            using (var context = new PeachtreeContext())
            {
                paises = context.Paises.ToList();
            }
            using (var context = new IngresosContext())
            {
                var _paises = paises
                    .Select(x => new Paises()
                    {
                        IsoNumerico = x.IsoNumerico,
                        Guidpaises = Guid.NewGuid(),
                        Dsblpaises = false,
                        Dplypaises = new byte(),
                        IsoNombre = x.IsoNombre.Length <= 50 ? x.IsoNombre : x.IsoNombre.Substring(0, 50),
                        IsoAlfa3 = x.IsoAlfa3,
                        IsoAlfa2 = x.IsoAlfa2,
                        EsDichter = x.Dichter
                    })
                .ToList();

                context.RunQuery("TRUNCATE TABLE [dbo].[paises]");
                context.Paises.AddRange(_paises);
                context.SaveChanges();
                return Ok();
            }
        }

        [Route("Divisiones")]
        [HttpPost]
        public IActionResult PostDivisiones()
        {
            var divisiones = new List<Infraestructure.ErpModel.TbDivisiones>();
            using (var context = new ErpContext())
            {
                divisiones = context.Divisiones.ToList();
            }
            using (var context = new IngresosContext())
            {
                var _divisiones = divisiones
                    .Select(x => new Divisiones()
                    {
                        IdDivisiones = x.Id,
                        Guiddivisiones = Guid.NewGuid(),
                        Dsbldivisiones = false,
                        Dplydivisiones = new byte(),
                        Nombre = x.Nombre.Length <= 50 ? x.Nombre : x.Nombre.Substring(0, 50),
                        Descripcion = x.Descripcion,
                        Activo = true
                    })
                .ToList();

                context.RunQuery("TRUNCATE TABLE [dbo].[divisiones]");
                context.Divisiones.AddRange(_divisiones);
                context.SaveChanges();
                return Ok();
            }
        }

        [Route("Clientes")]
        [HttpPost]
        public IActionResult PostClientes()
        {
            var clientes = new List<ClientesTest>();
            using (var context = new PeachtreeContext())
            {
                clientes = context.Clientes.ToList();
            }
            using (var context = new IngresosContext())
            {
                var _clientes = clientes
                    .Select(x => new Clientes()
                    {
                        IdClientes = x.Id,
                        Guidclientes = Guid.NewGuid(),
                        Dsblclientes = false,
                        Dplyclientes = new byte(),
                        Nombre = x.Nombre.Length <= 50 ? x.Nombre : x.Nombre.Substring(0, 50),
                        Factura = x.Factura.Length <= 50 ? x.Factura : x.Factura.Substring(0, 50),
                        Correo = x.Correo.Length <= 50 ? x.Correo : x.Correo.Substring(0, 50),
                        Telefono = x.Telefono.Length <= 50 ? x.Telefono : x.Telefono.Substring(0, 50),
                        Activo = true
                    })
                .ToList()
                .Take(800);

                context.RunQuery("TRUNCATE TABLE [dbo].[clientes]");
                context.Clientes.AddRange(_clientes);
                context.SaveChanges();
                return Ok();
            }
        }

        [Route("Bancos")]
        [HttpPost]
        public IActionResult PostBancos()
        {
            var bancos = new List<TbDicBancos>();
            using (var context = new PeachtreeContext())
            {
                bancos = context.DicBancos.ToList();
            }
            using (var context = new IngresosContext())
            {
                var _bancos = bancos
                    .Select(x => new Bancos()
                    {
                        Id = x.BancoId,
                        Guidbancos = Guid.NewGuid(),
                        Banco = x.BancoNombre,
                        Activo = x.BancoEstado
                    })
                .ToList()
                .Take(800);

                context.RunQuery("TRUNCATE TABLE [dbo].[bancos]");
                context.Bancos.AddRange(_bancos);
                context.SaveChanges();
                return Ok();
            }
        }

        [Route("CuentasBancarias")]
        [HttpPost]
        public IActionResult PostCuentasBancarias()
        {
            var cuentas = new List<TbCuentasBancarias>();
            using (var context = new PeachtreeContext())
            {
                cuentas = context.CuentasBancarias.Where(x => x.Cuenta.Length > 5).ToList();
            }
            using (var context = new IngresosContext())
            {
                var _cuentas = cuentas
                    .Select(x => new CuentasBancarias()
                    {
                        Id = x.Id,
                        GuidcuentasBancarias = Guid.NewGuid(),
                        BancoId = x.BancoId,
                        Cuenta = $"{x.Cuenta.Substring(0,5)}.......",
                        Activo = true
                    })
                .ToList()
                .Take(800);

                context.RunQuery("TRUNCATE TABLE [dbo].[cuentas_bancarias]");
                context.CuentasBancarias.AddRange(_cuentas);
                context.SaveChanges();
                return Ok();
            }
        }

        [Route("OrdenesVenta")]
        [HttpPost]
        public IActionResult PostOrdenesVenta()
        {
            var ordenes = new List<TbOrdenesDeVentaTest>();
            using (var context = new PeachtreeContext())
            {
                ordenes = context.OrdenesDeVenta.ToList();
            }
            using (var context = new IngresosContext())
            {
                var _ordenes = new List<OrdenesVenta>();
                var identity = context.OrdenesVenta.Any() ? context.OrdenesVenta.Max(x => x.Id) + 1 : 1;

                context.OrdenesVenta.RemoveRange(context.OrdenesVenta.Where(x => x.Cerrada == false));
                //context.SaveChanges();

                foreach (var x in ordenes.Where(x => !context.OrdenesVenta.Select(y => y.OrdenVenta).Contains(x.Ov)))
                {
                    _ordenes.Add(new OrdenesVenta()
                    {
                        Id = identity,
                        Baguid = Guid.NewGuid(),
                        OrdenVenta = x.Ov,
                        FechaCreacion = x.Fecha,
                        Monto = x.Monto,
                        ClienteId = x.ClienteId,
                        DivisionId = x.DivisionId,
                        PaisId = x.PaisId,
                        Descripcion = x.Descripcion,
                        Cerrada = false,
                        Finalent = 10009,
                        Bacreatedtime = 1639622991000
                    });
                    identity++;
                }
                //context.RunQuery("TRUNCATE TABLE [dbo].[ordenes_venta]");
                context.OrdenesVenta.AddRange(_ordenes);
                context.SaveChanges();
                return Ok();
            }
        }
    }
}
