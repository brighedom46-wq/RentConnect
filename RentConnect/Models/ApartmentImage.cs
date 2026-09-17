using System.ComponentModel.DataAnnotations;

namespace RentConnect.Models;

public class ApartmentImage
{
    public int Id { get; set; }

    public int ApartmentId { get; set; }

    [Required]
    [StringLength(500)]
    public string ImageUrl { get; set; } = string.Empty;

    public bool IsPrimary { get; set; }

    public DateTime DateUploaded { get; set; } =
        DateTime.UtcNow;

    public Apartment? Apartment { get; set; }
}