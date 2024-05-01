using Microsoft.EntityFrameworkCore;

using Backend.Models;
using Backend.Data;
using Microsoft.AspNetCore.Mvc;
namespace Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotasController : ControllerBase
    {
        private readonly DataBaseContext _context;

        public NotasController(DataBaseContext context)
        {
            _context = context;
        }

        //para mostrar Notas
        //http://localhost:5024/api/Notas
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Nota>>> GetNotas()
        {
            return await _context.Notas.ToListAsync();
        }

        
    }
}