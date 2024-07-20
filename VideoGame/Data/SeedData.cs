using QuickStay;


namespace QuickStay.Data;

internal static class SeedData
{
    internal static Task InitializeAsync(HotelContext db)
    {
        Hotel[] hotels =
        [
            new()
            {
                Id=1,
                Name="Amazed Hotel",
                AddressId=1,
                Email="amazed@hotel.com",
                Phone="111-111-1111",
                ImageUrl="img/hotels/AmazedHotel.jpg",
            },
            new()
            {
                Id=2,
                Name="Diamond Hotel",
                AddressId=2,
                Email="diamond@hotel.com",
                Phone="111-111-1111",
                ImageUrl="img/hotels/DiamondHotel.jpg",
            },
            new()
            {
                Id=3,
                Name="Family Escape Hotel",
                AddressId=3,
                Email="family@hotel.com",
                Phone="111-222-1111",
                ImageUrl="img/hotels/FamilyEscapeHotel.jpg",
            },
            new()
            {
                Id=4,
                Name="Majestic Hotel",
                AddressId=4,
                Email="MajesticHotel@hotel.com",
                Phone="234-455-1111",
                ImageUrl="img/hotels/MajesticHotel.jpg",
            },
            new()
            {
                Id=5,
                Name="Plaza Hotel",
                AddressId=5,
                Email="PlazaHotel@hotel.com",
                Phone="666-455-1111",
                ImageUrl="img/hotels/PlazaHotel.jpg",
            },
            new()
            {
                Id=6,
                Name="Relax Now Hotel",
                AddressId=6,
                Email="RelaxNowHotel@hotel.com",
                Phone="234-455-6768",
                ImageUrl="img/hotels/RelaxNowHotel.jpg",
            },
        ];

        Address[] addresses =
        [
            new()
            {
                Id=1, 
                Street="1301 Florida Mall Avenue", 
                City="Orlando", 
                State="FL",  
                PostalCode="32809", 
            },
            new()
            {
                Id=2, 
                Street="601 North Long Beach Blvd", 
                City="Long Beach", 
                State="CA",  
                PostalCode="90802", 
            },
            new()
            {
                Id=3, 
                Street="1230 Miami Avenue", 
                City="Miami", 
                State="FL",  
                PostalCode="32909", 
            },
            new()
            {
                Id=4, 
                Street="18 Blvd. Kukulcan", 
                City="Cancun", 
                State="Mexico",  
                PostalCode="77500", 
            },
            new()
            {
                Id=5, 
                Street="1740 W. Adams Ste", 
                City="Phoenix", 
                State="AZ",  
                PostalCode="85007", 
            },
            new()
            {
                Id=6, 
                Street="1740 Paradise", 
                City="Dhiffushi", 
                State="Maldives",  
                PostalCode="88907", 
            },
        ];
        RoomType[] roomTypes = [
            new(){
                Id=1,
                Name="Deluxe Room",
                Description="Luxurious furnishings and additional amenities. Includes a balcony",
                Bed1="Queen",
            }, 
            new(){
                Id=2,
                Name="Executive Suite",
                Description="Separate bedroom and living areas and include a kitchenette",
                Bed1="King",
            }, 
            new(){
                Id=3,
                Name="Deluxe Room",
                Description="Luxurious furnishings and additional amenities with a King bed.",
                Bed1="King",
            },
            new(){
                Id=4,
                Name="Standard Room",
                Description="Basic amenities, no balcony",
                Bed1="Queen",
            },
            new(){
                Id=5,
                Name="Presidential Suite",
                Description="Luxurious room, with 2 bedrooms, living spaces, and high-end amenities and services",
                Bed1="King",
                Bed2="King",
            },
            new(){
                Id=6,
                Name="Family Room",
                Description="Accommodate families, with extra amenities like a microwave and mini-fridge",
                Bed1="Queen",
                Bed2="Queen",
            }, 
            new(){
                Id=7,
                Name="Ocean View Suite",
                Description="Ocean View Suite with extra amenities like a microwave and mini-fridge",
                Bed1="King",
                Bed2="Queen",
            }

        ];
        HotelRoom[] hotelRooms = [
            new(){
                Id=1,
                RoomNumer="1032A",
                BasePrice=100.00m,
                MaxPeople=2,
                HotelId=1,
                RoomTypeId=1,
            },
            new(){
                Id=2,
                RoomNumer="102A",
                BasePrice=200.00m,
                MaxPeople=2,
                HotelId=1,
                RoomTypeId=2,
            },
            new(){
                Id=3,
                RoomNumer="1027A",
                BasePrice=150.00m,
                MaxPeople=2,
                HotelId=1,
                RoomTypeId=3,
            },
            new(){
                Id=4,
                RoomNumer="1029AA",
                BasePrice=800.00m,
                MaxPeople=4,
                HotelId=2,
                RoomTypeId=5,
            },
            new(){
                Id=5,
                RoomNumer="111",
                BasePrice=80.00m,
                MaxPeople=2,
                HotelId=2,
                RoomTypeId=4,
            },
            new(){
                Id=6,
                RoomNumer="107A",
                BasePrice=300.00m,
                MaxPeople=4,
                HotelId=3,
                RoomTypeId=6,
            },
            new(){
                Id=7,
                RoomNumer="223",
                BasePrice=200.00m,
                MaxPeople=2,
                HotelId=4,
                RoomTypeId=1,
            },
            new(){
                Id=8,
                RoomNumer="345",
                BasePrice=300.00m,
                MaxPeople=2,
                HotelId=4,
                RoomTypeId=2,
            },
            new(){
                Id=9,
                RoomNumer="4567",
                BasePrice=230.00m,
                MaxPeople=4,
                HotelId=5,
                RoomTypeId=7,
            },
            new(){
                Id=10,
                RoomNumer="1209",
                BasePrice=200.00m,
                MaxPeople=4,
                HotelId=6,
                RoomTypeId=7,
            },
        ];
        Reservation[] reservations= [
            new(){
                Id=1, 
                Name="Mary Rollins",
                StartDate= new DateOnly (2024, 07, 10),
                EndDate= new DateOnly (2024, 07, 15),
                IsConfirmed= false, 
                UserId="maryrollins@gmail.com",
                HotelRoomId=3
            },
            new(){
                Id=2, 
                Name="Mary Rollins",
                StartDate= new DateOnly (2024, 12, 10),
                EndDate= new DateOnly (2024, 12, 15),
                IsConfirmed= false, 
                UserId="maryrollins@gmail.com",
                HotelRoomId=6
            },
            new(){
                Id=3, 
                Name="Joe Doe",
                StartDate= new DateOnly (2024, 12, 10),
                EndDate= new DateOnly (2024, 12, 15),
                IsConfirmed= false, 
                UserId="joedoe@gmail.com",
                HotelRoomId=3
            }
        ];
        db.Hotels.AddRange(hotels);
        db.Address.AddRange(addresses);
        db.RoomTypes.AddRange(roomTypes);
        db.HotelRooms.AddRange(hotelRooms);
        db.Reservations.AddRange(reservations);

        return db.SaveChangesAsync();
    }
}