using System.ComponentModel.DataAnnotations;

namespace QuickStay;

public class Hotel
{
    public int Id { get; set; }

    [Required]
    [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Address ID is required.")]
    public int AddressId { get; set; }

    [Required]
    [EmailAddress(ErrorMessage = "Invalid Email Address.")]
    public string Email { get; set; }

    [Required]
    [Phone(ErrorMessage = "Invalid Phone Number.")]
    public string Phone { get; set; }

    [Required(ErrorMessage = "Image URL is required.")]
    public string ImageUrl { get; set; }
}
