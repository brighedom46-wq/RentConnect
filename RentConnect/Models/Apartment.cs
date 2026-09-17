using System.ComponentModel.DataAnnotations;

namespace RentConnect.Models;

public class Apartment
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Title { get; set; } = string.Empty;

    [Required]
    [StringLength(200)]
    public string Address { get; set; } = string.Empty;

    [Range(0, 1000000)]
    public decimal MonthlyRent { get; set; }

    [Range(0, 20)]
    public int Bedrooms { get; set; }

    [Range(0, 20)]
    public int Bathrooms { get; set; }

    [StringLength(1000)]
    public string Description { get; set; } = string.Empty;

    public string ImageUrl { get; set; } = string.Empty;

    public bool IsAvailable { get; set; } = true;

    public string LandlordId { get; set; } = string.Empty;

    public DateTime DatePosted { get; set; } = DateTime.UtcNow;

    public ICollection<ApartmentImage> Images { get; set; } =
    new List<ApartmentImage>();
}