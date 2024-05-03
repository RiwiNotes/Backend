using Microsoft.EntityFrameworkCore;

using Backend.Models;
using Backend.Data;
using Microsoft.AspNetCore.Mvc;
namespace Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriasController : ControllerBase
    {
        private readonly DataBaseContext _context;

        public CategoriasController(DataBaseContext context)
        {
            _context = context;
        }

        //para mostrar categorias
        // http://localhost:5024/api/Categorias
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Categoria>>> GetCategorias()
        {
            return await _context.Categorias.ToListAsync();
        }

        //crear una nueva categoria

        [HttpPost]
        public async Task<ActionResult<Categoria>> PostCategoria(Categoria categoria)
        {
            _context.Categorias.Add(categoria);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetCategoria", new { id = categoria.id}, categoria);
        }
    }
}