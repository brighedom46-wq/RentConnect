using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace RentConnect.Data
{
    public class ApplicationUser : IdentityUser
    {
        [MaxLength(100)]
        public string FullName { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        [MaxLength(30)]
        public string Gender { get; set; } = string.Empty;

        [MaxLength(100)]
        public string Occupation { get; set; } = string.Empty;

        [MaxLength(200)]
        public string CurrentAddress { get; set; } = string.Empty;

        [MaxLength(100)]
        public string City { get; set; } = string.Empty;

        [MaxLength(50)]
        public string Province { get; set; } = string.Empty;

        [MaxLength(20)]
        public string PostalCode { get; set; } = string.Empty;

        [MaxLength(100)]
        public string EmergencyContactName { get; set; } = string.Empty;

        [MaxLength(30)]
        public string EmergencyContactPhone { get; set; } = string.Empty;
    }
}