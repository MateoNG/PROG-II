using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PROGII_1w1_1er_API.Models;

namespace PROGII_1w1_1er_API.Controllers // act. 4.1
{
    [Route("4.1/[controller]")]
    [ApiController]
    public class FechaController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new Fecha());
        }
    }
}
