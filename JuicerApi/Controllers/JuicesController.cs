using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JuicerApi.Models;

namespace JuicerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JuicesController : ControllerBase
    {
        private readonly JuiceContext _context;

        public JuicesController(JuiceContext context)
        {
            _context = context;
        }

        // GET: api/Juices
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Juice>>> GetJuices()
        {
            return await _context.Juices.ToListAsync();
        }

        // GET: api/Juices/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Juice>> GetJuice(int id)
        {
            var juice = await _context.Juices.FindAsync(id);

            if (juice == null)
            {
                return NotFound();
            }

            return juice;
        }

        // PUT: api/Juices/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJuice(int id, Juice juice)
        {
            if (id != juice.Id)
            {
                return BadRequest();
            }

            _context.Entry(juice).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JuiceExists(id))
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

        // POST: api/Juices
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Juice>> PostJuice(Juice juice)
        {
            _context.Juices.Add(juice);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetJuice", new { id = juice.Id }, juice);
        }

        // DELETE: api/Juices/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJuice(int id)
        {
            var juice = await _context.Juices.FindAsync(id);
            if (juice == null)
            {
                return NotFound();
            }

            _context.Juices.Remove(juice);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JuiceExists(int id)
        {
            return _context.Juices.Any(e => e.Id == id);
        }
    }
}
