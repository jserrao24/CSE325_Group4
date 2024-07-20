using Microsoft.EntityFrameworkCore;
using QuickStay;

namespace QuickStay.Data;

public class HotelContext : DbContext
{
    public HotelContext(DbContextOptions<HotelContext> options) : base(options)
    {
    }
    public DbSet<User> Users { get; set; }
    public DbSet<Hotel> Hotels { get; set; }
     public DbSet<RoomType> RoomTypes { get; set; }
    public DbSet<HotelRoom> HotelRooms { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<Reviews> Reviews { get; set; }
    public DbSet<Roles> Roles { get; set; }
    public DbSet<Address> Address { get; set; }

}