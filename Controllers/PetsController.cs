using IT3045C_Final.Data;
using IT3045C_Final.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IT3045C_Final.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PetController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Pet
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pet>>> GetPets(int? id)
        {
            if (id == null || id == 0)
            {
                return await _context.Pets.Take(5).ToListAsync();
            }

            var pets = await _context.Pets.Where(p => p.TeamMemberId == id).ToListAsync();

            if (pets == null)
            {
                return NotFound();
            }

            return pets;
        }

        // POST: api/Pet
        [HttpPost]
        public async Task<ActionResult<Pet>> PostPet(Pet pet)
        {
            _context.Pets.Add(pet);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPets), new { id = pet.Id }, pet);
        }

        // PUT: api/Pet/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPet(int id, Pet pet)
        {
            if (id != pet.Id)
            {
                return BadRequest();
            }

            _context.Entry(pet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Pets.Any(e => e.Id == id))
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

        // DELETE: api/Pet/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePet(int id)
        {
            var pet = await _context.Pets.FindAsync(id);
            if (pet == null)
            {
                return NotFound();
            }

            _context.Pets.Remove(pet);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
