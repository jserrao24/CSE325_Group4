using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using QuickStay.Data;

namespace QuickStay.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private readonly HotelContext _db;
        private readonly ILogger<HotelsController> _logger;

        public HotelsController(HotelContext db, ILogger<HotelsController> logger)
        {
            _db = db;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<List<Hotel>>> GetHotels()
        {
            _logger.LogInformation("Fetching list of hotels");
            var hotels = await _db.Hotels.AsNoTracking().ToListAsync();

            if (hotels == null || !hotels.Any())
            {
                _logger.LogWarning("No hotels found");
                return NotFound();
            }

            _logger.LogInformation("Returning {HotelCount} hotels", hotels.Count);
            return Ok(hotels);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetHotelById(int id)
        {
            var hotel = await _db.Hotels.FirstOrDefaultAsync(h => h.Id == id);
            if (hotel == null)
            {
                return NotFound();
            }
            return Ok(hotel);
        }

        [HttpPost]
        public async Task<IActionResult> CreateHotel(Hotel hotel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _db.Hotels.Add(hotel);
            await _db.SaveChangesAsync();

            return CreatedAtAction(nameof(GetHotelById), new { id = hotel.Id }, hotel);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateHotel(int id, Hotel hotel)
        {
            if (id != hotel.Id)
            {
                return BadRequest();
            }

            _logger.LogInformation("Received update request for hotel with ID {HotelId}", id);
            _logger.LogInformation("Hotel details: {@Hotel}", hotel);

            if (!ModelState.IsValid)
            {
                _logger.LogWarning("Invalid model state for hotel with ID {HotelId}", id);
                return BadRequest(ModelState);
            }

            var existingHotel = await _db.Hotels.FindAsync(id);
            if (existingHotel == null)
            {
                return NotFound();
            }

            _db.Entry(existingHotel).CurrentValues.SetValues(hotel);

            try
            {
                await _db.SaveChangesAsync();
                _logger.LogInformation("Successfully updated hotel with ID {HotelId}", id);
            }
            catch (DbUpdateConcurrencyException ex)
            {
                if (!_db.Hotels.Any(e => e.Id == id))
                {
                    return NotFound();
                }
                else
                {
                    _logger.LogError(ex, "Error updating hotel with ID {HotelId}", id);
                    throw;
                }
            }

            return Ok(existingHotel);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHotel(int id)
        {
            var hotel = await _db.Hotels.FirstOrDefaultAsync(h => h.Id == id);
            if (hotel == null)
            {
                return NotFound();
            }
            _db.Hotels.Remove(hotel);
            await _db.SaveChangesAsync();
            return NoContent();
        }
    }
}
