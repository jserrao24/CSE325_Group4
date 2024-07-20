using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using QuickStay.Data;

namespace QuickStay.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ReservationsController : ControllerBase
{
    private readonly HotelContext _db;
    private readonly ILogger<ReservationsController> _logger;

    public ReservationsController(HotelContext db, ILogger<ReservationsController> logger)
    {
        _db = db;
        _logger = logger;
    }

    [HttpGet]
    public async Task<ActionResult<List<Reservation>>> GetReservations()
    {
        _logger.LogInformation("Fetching list of reservations");
        var reservations = await _db.Reservations.AsNoTracking().ToListAsync();

        if (reservations == null || !reservations.Any())
        {
            _logger.LogWarning("No reservations found");
            return NotFound();
        }

        _logger.LogInformation("Returning {ReservationCount} reservations", reservations.Count);
        return Ok(reservations);
    }
}
