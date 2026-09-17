using System.ComponentModel.DataAnnotations;

namespace RentConnect.Models;

public class ServiceRequest
{
    public int Id { get; set; }

    public int ApartmentId { get; set; }

    public Apartment? Apartment { get; set; }

    [Required]
    public string RenterId { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    public string RenterEmail { get; set; } = string.Empty;

    [Required]
    public string RequestType { get; set; } = "General Inquiry";

    [Required]
    [StringLength(150)]
    public string Subject { get; set; } = string.Empty;

    [Required]
    [StringLength(1500)]
    public string Message { get; set; } = string.Empty;

    public string Status { get; set; } = "Open";

    public DateTime DateCreated { get; set; } = DateTime.UtcNow;
}