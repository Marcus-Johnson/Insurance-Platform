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
        public DateTime DOB { set; get; }

        [StringLength(200)]
        [DisplayName("Email Address")]
        public string? EmailAddress { get; set; }

        //[StringLength(10)]
        //[DisplayName("Phone Number")]
        //public string? PhoneNumber { get; set; }

        [StringLength(50)]
        [DisplayName("Current Address")]
        public string? CurrentAddress { get; set; }

        [StringLength(50)]
        [DisplayName("Current City")]
        public string? CurrentCity { get; set; }

        [StringLength(20)]
        [DisplayName("Current Zipcode")]
        public string? CurrentZipcode { get; set; }

        [StringLength(10)]
        [DisplayName("Current State")]
        public string? CurrentState { get; set; }

        [StringLength(50)]
        [DisplayName("Current Employer")]
        public string? CurrentEmployer { get; set; }

        [StringLength(9)]
        [DisplayName("SSN")]
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