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

        //detalles en el controllador de notas
        [HttpGet("{id}")]
        public async Task<ActionResult<Nota>> GetDetalles(int id)
        {
            var nota = await _context.Notas.FindAsync(id);

            if (nota == null)
            {
                return NotFound();
            }
            return nota;
        }

        //crear una nueva nota 

        [HttpPost]
        public async Task<ActionResult<Nota>> PostNota(Nota nota)
        {
            _context.Notas.Add(nota);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetNotas", new { id = nota.id}, nota);
        }


        
        //eliminar nota
        [HttpDelete("{id}")]
        public async Task<ActionResult<Nota>> DeleteNota(int id)
        {
            var nota  = await _context.Notas.FindAsync(id);
            if( nota == null)
            {
                return NotFound();
            }
            _context.Notas.Remove(nota);
            await _context.SaveChangesAsync();

            return NoContent();
        }


        
        
        [ HttpPut("{id}")]
        public async Task<IActionResult> PutNote(int id, Nota nota)
        {
            if (id != nota.id)
            {
                return BadRequest();
            }

            _context.Entry(nota).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }
        
}
}