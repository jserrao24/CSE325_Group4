using QuickStay.Data;

namespace QuickStay;

public class Reservation
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required DateOnly StartDate { get; set; }
    public required DateOnly EndDate { get; set; }
    public required bool IsConfirmed { get; set; }
    public required string UserId { get; set; }
    public required int HotelRoomId { get; set; }
    
}