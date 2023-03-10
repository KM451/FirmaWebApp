using Firma.Data.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FirmaWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypCenyController : ControllerBase
    {
        private readonly FirmaDbContext _context;

        public TypCenyController(FirmaDbContext context)
        {
            _context = context;
        }

        // GET: api/TypCeny
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TypCeny>>> GetTypyCen()
        {
            return await _context.TypyCen.ToListAsync();
        }

        // GET: api/TypCeny/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TypCeny>> GetTypCeny(int id)
        {
            var typCeny = await _context.TypyCen.FindAsync(id);

            if (typCeny == null)
            {
                return NotFound();
            }

            return typCeny;
        }

        // PUT: api/TypCeny/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTypCeny(int id, TypCeny typCeny)
        {
            if (id != typCeny.IdTypuCeny)
            {
                return BadRequest();
            }

            _context.Entry(typCeny).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TypCenyExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TypCeny
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TypCeny>> PostTypCeny(TypCeny typCeny)
        {
            _context.TypyCen.Add(typCeny);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetTypCeny", new { id = typCeny.IdTypuCeny }, typCeny);
            return Ok(typCeny);
        }

        // DELETE: api/TypCeny/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTypCeny(int id)
        {
            var typCeny = await _context.TypyCen.FindAsync(id);
            if (typCeny == null)
            {
                return NotFound();
            }

            _context.TypyCen.Remove(typCeny);
            await _context.SaveChangesAsync();

            return Ok();
        }

        private bool TypCenyExists(int id)
        {
            return _context.TypyCen.Any(e => e.IdTypuCeny == id);
        }
    }
}
