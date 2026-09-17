using System.ComponentModel.DataAnnotations;
using RentConnect.Data;

namespace RentConnect.Models;

public class UnitAssignment
{
    public int Id { get; set; }

    [Required]
    public int ApartmentId { get; set; }

    public Apartment? Apartment { get; set; }

    [Required]
    public string RenterId { get; set; } = string.Empty;

    public ApplicationUser? Renter { get; set; }

    [Required]
    public string LandlordId { get; set; } = string.Empty;

    public DateTime MoveInDate { get; set; } = DateTime.Today;

    public DateTime AssignedDate { get; set; } = DateTime.UtcNow;

    public DateTime? EndDate { get; set; }

    public bool IsActive { get; set; } = true;
}