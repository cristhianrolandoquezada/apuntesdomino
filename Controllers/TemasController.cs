using ApuntesDominoAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApuntesDominoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemasController : ControllerBase
    {
        private readonly apuntesdominodbContext _context;
        public TemasController(apuntesdominodbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateTema([FromBody] Ttema model)
        {
            await _context.Ttemas.AddAsync(model);
            return Ok();
        }

        [HttpGet("search")]
        public IActionResult GetDefaultTema()
        {
            var result = _context.Ttemas
                        .Where(x => x.Defecto == "SI")
                        .Select(x => new { Nombre = x.Temnombre });
            return Ok(result);
        }
    }
}
