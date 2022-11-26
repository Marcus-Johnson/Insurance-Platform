using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NJInsurancePlatform.Models
{
    public class SignUpViewModel : IdentityUser
    {
        // Extended Attributes HERE

        [DisplayName("Customer ID")]
        public Guid? CustomerMUID { get; set; }

        [ForeignKey("Policy")]
        [ScaffoldColumn(false)]
        [DisplayName("Policy ID")]
        public Guid? PolicyMUID { get; set; }

        [StringLength(140)]
        [DisplayName("First Name")]
        [Required(ErrorMessage ="First Name is Required")]
        public string? FirstName { get; set; }

        [StringLength(140)]
        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last Name is Required")]
        public string? LastName { get; set; }
        
        [DisplayName("Date of Birth")]
        [Required(ErrorMessage = "Date Of Birth is Required")]
        public DateTime DOB { set; get; }


        [MaxLength(50)]
        [MinLength(5)]
        [Required(ErrorMessage = "Email Address Is Required")]
        public override string UserName { get => base.UserName; set => base.UserName = value; }

        [StringLength(12)]
        [DataType(DataType.PhoneNumber)]
        [Required, RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Phone Number Must Be 10 Numbers In Format (0000000000)")]
        [DisplayName("Phone Number")]
        public override string? PhoneNumber { get; set; }

        [Required(ErrorMessage = "Password Is Required")]
        public override string PasswordHash { get => base.PasswordHash; set => base.PasswordHash = value; }

        [StringLength(50)]
        [DisplayName("Current Address")]
        [Required(ErrorMessage = "Addresss is Required")]
        public string? CurrentAddress { get; set; }

        [StringLength(50)]
        [DisplayName("Current City")]
        [Required(ErrorMessage = "City is Required")]
        public string? CurrentCity { get; set; }

        [StringLength(20)]
        [DisplayName("Current Zipcode")]
        [Required(ErrorMessage = "ZipCode is Required")]
        public string? CurrentZipcode { get; set; }

        [StringLength(10)]
        [DisplayName("Current State")]
        [Required(ErrorMessage = "State is Required")]
        public string? CurrentState { get; set; }

        [StringLength(50)]
        [DisplayName("Current Employer")]
        [Required(ErrorMessage = "Employer is Required")]
        public string? CurrentEmployer { get; set; }

        [StringLength(11)]
        [DisplayName("SSN")]
        [Required(ErrorMessage = "SSN is Required")]
        [RegularExpression(@"^\d{9}|\d{3}-\d{2}-\d{4}$", ErrorMessage = "Social Security Number Must Be 9 Numbers in Format (123456789)")]
        public string? SSN { get; set; }

        [StringLength(15)]
        [DisplayName("License Number")]
        [Required(ErrorMessage = "License is Required")]
        public string? LicenseNumber { get; set; }

        [DisplayName("Are you the primary policy holder?")]
        [Required(ErrorMessage = "Are You The Primary Account Holder is Required")]
        public bool IsPrimaryPolicyHolder { get; set; }


        [DisplayName("Gender")]
        [Required(ErrorMessage = "Gender Is Required")]
        //public string? Gender { get; set; }
        public string? Gender { get; set; }


        [DisplayName("Date Created")]
        public DateTime? CreatedDate { get; set; }

    }
}