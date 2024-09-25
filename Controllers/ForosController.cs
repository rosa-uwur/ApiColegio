using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiColegio.Context;
using ApiColegio.Models;

namespace ApiColegio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ForosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Foros
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Foro>>> GetForos()
        {
            return await _context.Foros.ToListAsync();
        }

        // GET: api/Foros/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Foro>> GetForo(int id)
        {
            var foro = await _context.Foros.FindAsync(id);

            if (foro == null)
            {
                return NotFound();
            }

            return foro;
        }

        // PUT: api/Foros/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutForo(int id, Foro foro)
        {
            if (id != foro.Id)
            {
                return BadRequest();
            }

            _context.Entry(foro).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ForoExists(id))
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

        // POST: api/Foros
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Foro>> PostForo(Foro foro)
        {
            _context.Foros.Add(foro);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetForo", new { id = foro.Id }, foro);
        }

        // DELETE: api/Foros/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteForo(int id)
        {
            var foro = await _context.Foros.FindAsync(id);
            if (foro == null)
            {
                return NotFound();
            }

            _context.Foros.Remove(foro);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ForoExists(int id)
        {
            return _context.Foros.Any(e => e.Id == id);
        }
    }
}
