namespace QuickStay;

public class HotelRoom
{
    public int Id { get; set; }
    // RoomNumber is string so it can have letters too, like some places havr 1001A
    public required string RoomNumer { get; set; }
    public required decimal BasePrice { get; set; }
    public required int MaxPeople { get; set; }
    public required int HotelId { get; set; }
    public required int RoomTypeId { get; set; }
    
}