using CsharpAdvanced23_24.Models;
using CsharpAdvanced23_24.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CsharpAdvanced23_24.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LandlordsController : ControllerBase
    {
        // OLD when DbContext was used instead of Repository
        //private readonly CsharpAdvanced23_24Context _context;

        //public LandlordsController(CsharpAdvanced23_24Context context)
        //{
        //    _context = context;
        //} 

        private readonly IAirbnbRepository<Landlord> _landlordRepository;
        public LandlordsController(IAirbnbRepository<Landlord> landlordRepository)
        {
            _landlordRepository = landlordRepository;
        }



        //Below is scaffolded code which might not be used after using a repository
        //Keeping it commented for future API calls that need to be made

        //// GET: api/Landlords
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Landlord>>> GetLandlord()
        //{
        //    if (_context.Landlord == null)
        //    {
        //        return NotFound();
        //    }
        //    return await _context.Landlord.ToListAsync();
        //}

        //// GET: api/Landlords/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Landlord>> GetLandlord(int id)
        //{
        //    if (_context.Landlord == null)
        //    {
        //        return NotFound();
        //    }
        //    var landlord = await _context.Landlord.FindAsync(id);

        //    if (landlord == null)
        //    {
        //        return NotFound();
        //    }

        //    return landlord;
        //}

        //// PUT: api/Landlords/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutLandlord(int id, Landlord landlord)
        //{
        //    if (id != landlord.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(landlord).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!LandlordExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Landlords
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Landlord>> PostLandlord(Landlord landlord)
        //{
        //    if (_context.Landlord == null)
        //    {
        //        return Problem("Entity set 'CsharpAdvanced23_24Context.Landlord'  is null.");
        //    }
        //    _context.Landlord.Add(landlord);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetLandlord", new { id = landlord.Id }, landlord);
        //}

        //// DELETE: api/Landlords/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteLandlord(int id)
        //{
        //    if (_context.Landlord == null)
        //    {
        //        return NotFound();
        //    }
        //    var landlord = await _context.Landlord.FindAsync(id);
        //    if (landlord == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Landlord.Remove(landlord);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool LandlordExists(int id)
        //{
        //    return (_context.Landlord?.Any(e => e.Id == id)).GetValueOrDefault();
        //}
    }
}
