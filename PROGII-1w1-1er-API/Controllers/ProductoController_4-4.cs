using Microsoft.AspNetCore.Mvc;
using PROGII_1w1_1er_API.Models;
using System.Reflection.Metadata.Ecma335;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PROGII_1w1_1er_API.Controllers
{
    [Route("4.4/[controller]")]
    [ApiController]
    public class ProductoController_4_4 : ControllerBase
    {
        private static List<Producto> lProductos = new List<Producto>();

        // GET: api/<ProductoController_4_4>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(lProductos);
        }

        // GET api/<ProductoController_4_4>/5
        [HttpGet("{codigo}")]
        public IActionResult Get(int codigo)
        {
            foreach (Producto p in lProductos)
            {
                if (p.Codigo == codigo)
                {
                    return Ok(p.Nombre);
                }
            };
            return BadRequest("No se encontro el producto (Error 404)");
        }

        // POST api/<ProductoController_4_4>
        [HttpPost]
        public IActionResult Post([FromBody] Producto prod)
        {
            if (prod == null || prod.Codigo < 0 || prod.Precio < 1)
            {
                return BadRequest("Datos erróneos");
            }
            lProductos.Add(prod);
            return Ok(prod);
        }

        // PUT api/<ProductoController_4_4>/5
        [HttpPut("{codigo}")]
        public IActionResult Put(int codigo, [FromBody] Producto pActualizado)
        {
            foreach (Producto p in lProductos)
            {
                if (p.Codigo == codigo)
                {
                    p.Precio = pActualizado.Precio;
                    p.Nombre = pActualizado.Nombre;
                    p.Codigo = pActualizado.Codigo;

                    return Ok(p);
                }
            }
            return BadRequest("No se pudo Actualizar (No existe el código suministrado)");
        }

        // DELETE api/<ProductoController_4_4>/5
        [HttpDelete("{codigo}")]
        public IActionResult Delete(int codigo)
        {
            foreach (Producto p in lProductos)
            {
                if (p.Codigo == codigo)
                {
                    lProductos.Remove(p);

                    return Ok(lProductos);
                }
            }
            return BadRequest("No se pudo Eliminar (No existe el código suministrado)");
        }
    }
}
