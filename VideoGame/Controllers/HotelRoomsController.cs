using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuickStay.Data;

namespace QuickStay.Controllers;

[Route("api/[controller]")]
[ApiController]public class HotelRoomsController : Controller
{
    private readonly HotelContext _db;

    public HotelRoomsController(HotelContext db)
    {
        _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<List<HotelRoom>>> GetRooms()
    {
        return await _db.HotelRooms.AsNoTracking().ToListAsync();
    }
}