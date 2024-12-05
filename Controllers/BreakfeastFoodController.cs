using IT3045C_Final.Data;
using IT3045C_Final.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IT3045C_Final.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BreakfastFoodController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public BreakfastFoodController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/BreakfastFood
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BreakfastFood>>> GetBreakfastFoods(int? id)
        {
            if (id == null || id == 0)
            {
                return await _context.BreakfastFood.Take(5).ToListAsync();
            }

            var breakfastFood = await _context.BreakfastFood.Where(bf => bf.TeamMemberId == id).ToListAsync();

            if (breakfastFood == null)
            {
                return NotFound();
            }

            return breakfastFood;
        }

        // POST: api/BreakfastFood
        [HttpPost]
        public async Task<ActionResult<BreakfastFood>> PostBreakfastFood(BreakfastFood breakfastFood)
        {
            _context.BreakfastFood.Add(breakfastFood);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetBreakfastFoods), new { id = breakfastFood.Id }, breakfastFood);
        }

        // PUT: api/BreakfastFood/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBreakfastFood(int id, BreakfastFood breakfastFood)
        {
            if (id != breakfastFood.Id)
            {
                return BadRequest();
            }

            _context.Entry(breakfastFood).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.BreakfastFood.Any(e => e.Id == id))
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

        // DELETE: api/BreakfastFood/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBreakfastFood(int id)
        {
            var breakfastFood = await _context.BreakfastFood.FindAsync(id);
            if (breakfastFood == null)
            {
                return NotFound();
            }

            _context.BreakfastFood.Remove(breakfastFood);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
