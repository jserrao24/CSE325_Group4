namespace QuickStay;

public class Reviews
{
    public int Id { get; set; }
    public required string Text { get; set; }
    public required DateTime Date { get; set; }
    public required int UserId { get; set; }
    public required int HotelRoomId { get; set; }
    
}