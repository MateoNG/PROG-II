using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using PROGII_1w1_1er_API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PROGII_1w1_1er_API.Controllers // act. 4.2
{
    [Route("4.2/[controller]")]
    [ApiController]
    public class MonedaController : ControllerBase
    {
        private static List<Moneda> lMonedas = new List<Moneda>() ;

        // GET: api/<MonedaController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(lMonedas);
        }

        //GET api/<MonedaController>/5
        [HttpGet("{nombre}")]
        public IActionResult Get(string nombre)
        {
            foreach (Moneda m in lMonedas)
            {
                if (m.Nombre == nombre)
                {
                    return Ok(m.ValorEnPesos);
                }
            };
            return NotFound("peugeot 404 (No se encontro la moneda)");
        }

        // POST api/<MonedaController>
        [HttpPost] //es un decorador (dice que hace)
        public IActionResult Post([FromBody] Moneda moneda)
        {
            if (moneda == null || string.IsNullOrEmpty(moneda.Nombre))
                return BadRequest("Moneda incorrecta");
            lMonedas.Add(moneda);
            return Ok(moneda);

        }

        // PUT api/<MonedaController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/<MonedaController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
