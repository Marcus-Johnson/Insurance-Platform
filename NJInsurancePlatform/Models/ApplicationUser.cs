using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NJInsurancePlatform.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Extended Attributes HERE

        [DisplayName("Customer ID")]
        public Guid? CustomerMUID { get; set; }

        [DisplayName("Beneficiary ID")]
        public Guid? BeneficiaryMUID { get; set; }

        [ForeignKey("Policy")]
        [ScaffoldColumn(false)]
        [DisplayName("Policy ID")]
        public Guid? PolicyMUID { get; set; }

        [StringLength(140)]
        [DisplayName("First Name")]
        public string? FirstName { get; set; }

        [StringLength(140)]
        [DisplayName("Last Name")]
        public string? LastName { get; set; }
        
        [DisplayName("Date of Birth")]
        [Required(ErrorMessage = "Date Of Birth is Required")]
        public DateTime DOB { set; get; }

        [StringLength(200)]
        [DisplayName("Email Address")]
        public string? EmailAddress { get; set; }

        [MaxLength(50)]
        [MinLength(5)]
        public override string UserName { get => base.UserName; set => base.UserName = value; }


        [StringLength(50)]
        [DisplayName("Current Address")]
        public string? CurrentAddress { get; set; }

        [StringLength(50)]
        [DisplayName("Current City")]
        public string? CurrentCity { get; set; }

        [StringLength(10)]
        [DisplayName("Current Zipcode")]
        public string? CurrentZipcode { get; set; }

        [StringLength(10)]
        [DisplayName("Current State")]
        public string? CurrentState { get; set; }

        [StringLength(50)]
        [DisplayName("Current Employer")]
        public string? CurrentEmployer { get; set; }

        [StringLength(11)]
        [DisplayName("SSN")]
        [RegularExpression(@"^\d{9}|\d{3}-\d{2}-\d{4}$", ErrorMessage = "Invalid Social Security Number. Format Example (123456789)")]
        public string? SSN { get; set; }

        [StringLength(15)]
        [DisplayName("License Number")]
        public string? LicenseNumber { get; set; }

        [DisplayName("Are you the primary policy holder?")]
        public bool IsPrimaryPolicyHolder { get; set; }

        [DisplayName("Gender")]
        public string? Gender { get; set; }

        [DisplayName("Date Created")]
        public DateTime? CreatedDate { get; set; }

        [DisplayName("Is this policy active?")]
        public bool Active { get; set; }
    }
}