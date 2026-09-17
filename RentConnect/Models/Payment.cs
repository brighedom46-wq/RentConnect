using System.ComponentModel.DataAnnotations;

namespace RentConnect.Models
{
    public class Payment
    {
        public int Id { get; set; }

        [Required]
        public int UtilityBillId { get; set; }

        public UtilityBill? UtilityBill { get; set; }

        public string RenterId { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string RenterEmail { get; set; } = string.Empty;

        [Range(0.01, 1000000)]
        public decimal Amount { get; set; }

        [Required]
        public string PaymentMethod { get; set; } = string.Empty;

        public string TransactionReference { get; set; } = string.Empty;

        public string Status { get; set; } = "Completed";

        public DateTime PaymentDate { get; set; } = DateTime.UtcNow;
    }
}