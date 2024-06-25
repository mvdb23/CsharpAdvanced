using CsharpAdvanced23_24.Models;
using CsharpAdvanced23_24.Services;
using Microsoft.AspNetCore.Mvc;

namespace CsharpAdvanced23_24.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly ISearchService _searchService;
        public LocationsController(ISearchService searchService)
        {
            _searchService = searchService;
        }

        // GET: api/Locations
        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<Location>>> GetAllLocations()
        {
            var locations = await _searchService.GetAllLocations();
            return Ok(locations);
            //return (IEnumerable<Location>)_searchService.GetAllLocations();
        }



        //Below is scaffolded code which might not be used after using a repository
        //Keeping it commented for future API calls that need to be made

        //private readonly CsharpAdvanced23_24Context _context;

        //public LocationsController(CsharpAdvanced23_24Context context)
        //{
        //    _context = context;
        //}

        //// GET: api/Locations
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Location>>> GetLocation()
        //{
        //  if (_context.Location == null)
        //  {
        //      return NotFound();
        //  }
        //    return await _context.Location.ToListAsync();
        //}

        //// GET: api/Locations/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Location>> GetLocation(int id)
        //{
        //  if (_context.Location == null)
        //  {
        //      return NotFound();
        //  }
        //    var location = await _context.Location.FindAsync(id);

        //    if (location == null)
        //    {
        //        return NotFound();
        //    }

        //    return location;
        //}

        //// PUT: api/Locations/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutLocation(int id, Location location)
        //{
        //    if (id != location.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(location).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!LocationExists(id))
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

        //// POST: api/Locations
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Location>> PostLocation(Location location)
        //{
        //  if (_context.Location == null)
        //  {
        //      return Problem("Entity set 'CsharpAdvanced23_24Context.Location'  is null.");
        //  }
        //    _context.Location.Add(location);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetLocation", new { id = location.Id }, location);
        //}

        //// DELETE: api/Locations/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteLocation(int id)
        //{
        //    if (_context.Location == null)
        //    {
        //        return NotFound();
        //    }
        //    var location = await _context.Location.FindAsync(id);
        //    if (location == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Location.Remove(location);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool LocationExists(int id)
        //{
        //    return (_context.Location?.Any(e => e.Id == id)).GetValueOrDefault();
        //}
    }
}
