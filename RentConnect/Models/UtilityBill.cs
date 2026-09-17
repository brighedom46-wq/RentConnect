using System.ComponentModel.DataAnnotations;

namespace RentConnect.Models
{
    public class UtilityBill
    {
        public int Id { get; set; }

        [Required]
        public int ApartmentId { get; set; }

        public Apartment? Apartment { get; set; }

        public string RenterId { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string RenterEmail { get; set; } = string.Empty;

        [Required]
        public string BillType { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        [Range(0.01, 1000000)]
        public decimal Amount { get; set; }

        public DateTime DueDate { get; set; } = DateTime.Today.AddDays(30);

        public string Status { get; set; } = "Unpaid";

        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        public DateTime? DatePaid { get; set; }
    }
}