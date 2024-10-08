﻿using System;
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
    public class MaestrosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public MaestrosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Maestros
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Maestro>>> GetMaestros()
        {
            return await _context.Maestros.ToListAsync();
        }

        // GET: api/Maestros/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Maestro>> GetMaestro(int id)
        {
            var maestro = await _context.Maestros.FindAsync(id);

            if (maestro == null)
            {
                return NotFound();
            }

            return maestro;
        }

        // PUT: api/Maestros/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMaestro(int id, Maestro maestro)
        {
            if (id != maestro.Id)
            {
                return BadRequest();
            }

            _context.Entry(maestro).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MaestroExists(id))
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

        // POST: api/Maestros
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Maestro>> PostMaestro(Maestro maestro)
        {
            _context.Maestros.Add(maestro);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMaestro", new { id = maestro.Id }, maestro);
        }

        // DELETE: api/Maestros/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMaestro(int id)
        {
            var maestro = await _context.Maestros.FindAsync(id);
            if (maestro == null)
            {
                return NotFound();
            }

            _context.Maestros.Remove(maestro);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MaestroExists(int id)
        {
            return _context.Maestros.Any(e => e.Id == id);
        }
    }
}
