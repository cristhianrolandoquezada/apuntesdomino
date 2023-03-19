using ApuntesDominoAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApuntesDominoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FondosController : ControllerBase
    {
        private readonly apuntesdominodbContext _context;
        public FondosController(apuntesdominodbContext context)
        {
            _context = context;
        }

        // GET: api/<FondosController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _context.Tfondos.ToListAsync();
            return Ok(result);
        }

    }
}
