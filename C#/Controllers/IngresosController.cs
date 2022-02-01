using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TesisApi.Infraestructure;

namespace TesisApi.Controllers
{
    [Route("api/v1/[controller]")]
    public class IngresosController : ControllerBase
    {
        [Route("Paises")]
        [HttpGet]
        public IActionResult GetPaises()
        {
            using (var context = new IngresosContext())
            {
                var result = context.Paises.ToList();
                return Ok(result);
            }
        }

        [Route("Divisiones")]
        [HttpGet]
        public IActionResult GetDivisiones()
        {
            using (var context = new IngresosContext())
            {
                var result = context.Divisiones.ToList();
                return Ok(result);
            }
        }

        [Route("Clientes")]
        [HttpGet]
        public IActionResult GetClientes()
        {
            using (var context = new IngresosContext())
            {
                var result = context.Clientes.ToList();
                return Ok(result);
            }
        }

        [Route("Ingreso")]
        [HttpGet]
        public IActionResult GetIngreso()
        {
            using (var context = new IngresosContext())
            {
                var result = context.OrdenesVenta.ToList();
                return Ok(result);
            }
        }
    }
}
