using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GateCommunityMvc.Models;

namespace GateCommunityMvc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlatmodelsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public FlatmodelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Flatmodels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Flatmodel>>> GetFlats()
        {
            return await _context.Flats.ToListAsync();
        }

        // GET: api/Flatmodels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Flatmodel>> GetFlatmodel(int id)
        {
            var flatmodel = await _context.Flats.FindAsync(id);

            if (flatmodel == null)
            {
                return NotFound();
            }

            return flatmodel;
        }

        // PUT: api/Flatmodels/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFlatmodel(int id, Flatmodel flatmodel)
        {
            if (id != flatmodel.Flatid)
            {
                return BadRequest();
            }

            _context.Entry(flatmodel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FlatmodelExists(id))
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

        // POST: api/Flatmodels
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Flatmodel>> PostFlatmodel(Flatmodel flatmodel)
        {
            _context.Flats.Add(flatmodel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFlatmodel", new { id = flatmodel.Flatid }, flatmodel);
        }

        // DELETE: api/Flatmodels/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Flatmodel>> DeleteFlatmodel(int id)
        {
            var flatmodel = await _context.Flats.FindAsync(id);
            if (flatmodel == null)
            {
                return NotFound();
            }

            _context.Flats.Remove(flatmodel);
            await _context.SaveChangesAsync();

            return flatmodel;
        }

        private bool FlatmodelExists(int id)
        {
            return _context.Flats.Any(e => e.Flatid == id);
        }
    }
}
