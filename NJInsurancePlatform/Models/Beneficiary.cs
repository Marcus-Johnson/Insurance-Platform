using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace NJInsurancePlatform.Models
{
    public class Beneficiary
    {
        [Key]
        [ScaffoldColumn(false)]
        [DisplayName("Beneficiary ID")]
        public Guid BeneficiaryMUID { get; set; }

        [ForeignKey("CustomerMUID")]
        [ScaffoldColumn(false)]
        [DisplayName("Customer ID")]
        public Guid CustomerMUID { get; set; }

        [Required(ErrorMessage = "Missing field: First Name")]
        [StringLength(25)]
        [DisplayName("First Name")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Missing field: Last Name")]
        [StringLength(25)]
        [DisplayName("Last Name")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Missing field: Email Address")]
        [StringLength(100)]
        [DisplayName("Email Address")]
        public string? EmailAddress { get; set; }

        [Required(ErrorMessage = "Missing field: Phone Number")]
        [StringLength(10)]
        [DisplayName("Phone Number")]
        public string? PhoneNumber { get; set; }

        [Required(ErrorMessage = "Missing field: SSN")]
        [StringLength(9)]
        [DisplayName("SSN")]
        public string? SSN { get; set; }

        [Required(ErrorMessage = "Missing field: License Number")]
        [StringLength(15)]
        [DisplayName("License Number")]
        public string? LicenseNumber { get; set; }

        [Required(ErrorMessage = "Missing field: Gender")]
        [DisplayName("Gender")]
        public string? Gender { get; set; }

        [Required(ErrorMessage = "Missing field: Date Created")]
        [DisplayName("Date Created")]
        public DateTime CreatedDate { get; set; }

        [Required(ErrorMessage = "Missing field: Is this member active?")]
        [DisplayName("Is this member active?")]

        public bool Active { get; set; }
    }
}
