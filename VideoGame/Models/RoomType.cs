namespace QuickStay;

public class RoomType
{
    public int Id { get; set; }
    public  required string Name { get; set; }
    public required string Description { get; set; }
    public required string Bed1 { get; set; }
    public string? Bed2 { get; set; }


}