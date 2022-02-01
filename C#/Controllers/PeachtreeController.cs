using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TesisApi.Infraestructure;

namespace TesisApi.Controllers
{
    [Route("api/v1/[controller]")]
    public class PeachtreeController : ControllerBase
    {
        [Route("Paises")]
        [HttpGet]
        public IActionResult GetPaises()
        {
            using (var context = new PeachtreeContext())
            {
                var result = context.Paises.ToList();
                return Ok(result);
            }
        }

        [Route("Divisiones")]
        [HttpGet]
        public IActionResult GetDivisiones()
        {
            using (var context = new ErpContext())
            {
                var result = context.Divisiones.ToList();
                return Ok(result);
            }
        }

        [Route("Clientes")]
        [HttpGet]
        public IActionResult GetClientes()
        {
            using (var context = new PeachtreeContext())
            {
                var result = context.Clientes.ToList();
                return Ok(result);
            }
        }

        [Route("OrdenesDeVenta")]
        [HttpGet]
        public IActionResult GetOrdenesDeVenta()
        {
            using (var context = new PeachtreeContext())
            {
                var result = context.OrdenesDeVenta.ToList();
                return Ok(result);
            }
        }
    }
}
