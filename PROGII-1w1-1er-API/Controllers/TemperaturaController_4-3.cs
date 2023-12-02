using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PROGII_1w1_1er_API.Models;

namespace PROGII_1w1_1er_API.Controllers
{
    [Route("4.3/[controller]")]
    [ApiController]
    public class TemperaturaController : ControllerBase
    {
        private static RegistroTemp_4_3 registro = null;

        [HttpGet]
        public IActionResult Get()
        {
            registro = RegistroTemp_4_3.ObtenerInstancia();
            return Ok(registro.lTemperaturas);
        }

        [HttpGet("{iot}")]
        public IActionResult Get(int iot)
        {
            registro = RegistroTemp_4_3.ObtenerInstancia();

            foreach (Temperatura_4_3 t in registro.lTemperaturas)
            {
                if (t.IOT == iot)
                {
                    return Ok(t.Valor);
                }
            };
            return NotFound("Peugeot 404 (No se encontraron Temperaturas que coincidan)");
        }

        
        [HttpPost]
        public IActionResult Post([FromBody] Temperatura_4_3 temp)
        {
            registro = RegistroTemp_4_3.ObtenerInstancia();

            if (temp == null)
            {
                return BadRequest("Chevrolet 400 (Temperatura incompleta)");
            }
            else
            {
                registro.lTemperaturas.Add(temp);
                return Ok(temp);
            }
        }
    }
}
