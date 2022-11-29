using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NJInsurancePlatform.Models
{
    public class Customer
    {
        [Key]
        [ScaffoldColumn(false)]
        [DisplayName("Customer ID")]
        public Guid CustomerMUID { get; set; }

        [ForeignKey("Policy")]
        [ScaffoldColumn(false)]
        [DisplayName("Policy ID")]
        public Guid PolicyMUID { get; set; }

        [Required(ErrorMessage = "Missing field: First Name")]
        [StringLength(140)]
        [DisplayName("First Name")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Missing field: Last Name")]
        [StringLength(140)]
        [DisplayName("Last Name")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Missing field: Email Address")]
        [StringLength(200)]
        [DisplayName("Email Address")]
        public string? EmailAddress { get; set; }

        [Required(ErrorMessage = "Missing field: Phone Number")]
        [StringLength(10)]
        [DisplayName("Phone Number")]
        public string? PhoneNumber { get; set; }

        [Required(ErrorMessage = "Missing field: Current Address")]
        [StringLength(50)]
        [DisplayName("Current Address")]
        public string? CurrentAddress { get; set; }

        [Required(ErrorMessage = "Missing field: Current City")]
        [StringLength(50)]
        [DisplayName("Current City")]
        public string? CurrentCity { get; set; }

        [Required(ErrorMessage = "Missing field: Current Zipcode")]
        [StringLength(20)]
        [DisplayName("Current Zipcode")]
        public string? CurrentZipcode { get; set; }

        [Required(ErrorMessage = "Missing field: Current State")]
        [StringLength(10)]
        [DisplayName("Current State")]
        public string? CurrentState { get; set; }

        [Required(ErrorMessage = "Missing field: Current Employer")]
        [StringLength(50)]
        [DisplayName("Current Employer")]
        public string? CurrentEmployer { get; set; }

        [Required(ErrorMessage = "Missing field: SSN")]
        [StringLength(9)]
        [DisplayName("SSN")]
        public string? SSN { get; set; }

        [Required(ErrorMessage = "Missing field: License Number")]
        [StringLength(15)]
        [DisplayName("License Number")]
        public string? LicenseNumber { get; set; }

        [Required(ErrorMessage = "Missing field: Are you the primary policy holder?")]
        [DisplayName("Are you the primary policy holder?")]
        public bool IsPrimaryPolicyHolder { get; set; }

        [Required(ErrorMessage = "Missing field: Gender")]
        [DisplayName("Gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Missing field: Date Created")]
        [DisplayName("Date Created")]
        public string CreatedDate { get; set; } = null!;

        [Required(ErrorMessage = "Missing field: Is this policy active?")]
        [DisplayName("Is this policy active?")]
        public bool Active { get; set; }
    }
}
