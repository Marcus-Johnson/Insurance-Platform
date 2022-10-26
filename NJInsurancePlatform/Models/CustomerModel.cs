using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NJInsurancePlatform.Models
{
    public class CustomerModel
    {
        [Key]
        public int CustomerMuid { get; set; }
        [ForeignKey("PolicyModel")] // Change the argument here so that it matches the name of the policy model
        [ScaffoldColumn(false)]
        public int PolicyMuid { get; set; }
        [Required(ErrorMessage = "Missing field: First Name")]
        [StringLength(140)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Missing field: Last Name")]
        [StringLength(140)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Missing field: Email Address")]
        [StringLength(200)]
        public string EmailAddress { get; set; }
        [Required(ErrorMessage = "Missing field: Phone Number")]
        [StringLength(10)]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Missing field: SSN")]
        [StringLength(9)]
        public string SSN { get; set; }
        [Required(ErrorMessage = "Missing field: License Number")]
        [StringLength(15)]
        public string LicenseNumber { get; set; }
        [Required(ErrorMessage = "Missing field: Primary policy holder?")]
        public bool IsPrimaryPolicyHolder { get; set; }
        [Required(ErrorMessage = "Missing field: Gender")]
        public bool Gender { get; set; }
        [Required(ErrorMessage = "Missing field: Date Created")]
        public string CreatedDate { get; set; } = null!;
        [Required(ErrorMessage = "Missing field: Is this policy active?")]
        public bool Active { get; set; }

    }
}
