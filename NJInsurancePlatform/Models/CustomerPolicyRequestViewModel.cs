using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NJInsurancePlatform.Models
{
    public class CustomerPolicyRequestViewModel
    {
        public Product Product { get; set; }
        public ApplicationUser Customer { get; set; }
        public PolicyRequest PolicyRequest { get; set; }
        public CustomerPolicyRequestViewModel()
        {
            this.Product = new Product();
            this.Customer = new ApplicationUser();
            this.PolicyRequest = new PolicyRequest();
        }

        //[DisplayName("Customer ID")]
        //public Guid CustomerMUID { get; set; }

        //[DisplayName("Policy ID")]
        //public Guid PolicyMUID { get; set; }

        //[DisplayName("First Name")]
        //public string? FirstName { get; set; }

        //[DisplayName("Last Name")]
        //public string? LastName { get; set; }

        //[DisplayName("Email Address")]
        //public string? EmailAddress { get; set; }

        //[DisplayName("Phone Number")]
        //public string? PhoneNumber { get; set; }

        //[DisplayName("Current Address")]
        //public string? CurrentAddress { get; set; }

        //[DisplayName("Current City")]
        //public string? CurrentCity { get; set; }

        //[DisplayName("Current Zipcode")]
        //public string? CurrentZipcode { get; set; }

        //[DisplayName("Current State")]
        //public string? CurrentState { get; set; }

        //[DisplayName("Current Employer")]
        //public string? CurrentEmployer { get; set; }

        //[DisplayName("SSN")]
        //public string? SSN { get; set; }

        //[DisplayName("License Number")]
        //public string? LicenseNumber { get; set; }

        //[DisplayName("Are you the primary policy holder?")]
        //public bool IsPrimaryPolicyHolder { get; set; }

        //[DisplayName("Gender")]
        //public string Gender { get; set; }

        //[DisplayName("Date Created")]
        //public string CreatedDate { get; set; } = null!;

        //[DisplayName("Is this policy active?")]
        //public bool Active { get; set; }

        //[DisplayName("Policy Number")]
        //[Required(ErrorMessage = "Missing - PolicyNumber")]
        //public Guid ProductMUID { get; set; }

        //[DisplayName("Name Of Policy")]
        //public string? ProductName { get; set; }

        //[DisplayName("Deductible ")]
        //public double? Deductible { get; set; }           

        //[DisplayName("Price")]
        //public double? Price { get; set; }        

        //[DisplayName("Description ")]
        //public string? Description { get; set; }

        //[DisplayName("Out Of Pocket Limit")]
        //public double? OutOfPocketLimit { get; set; }

        //[DisplayName("Annual Limit Of Coverage")]
        //public double? AnnualLimitOfCoverage { get; set; }

        //[DisplayName("Policy Payment is Due")]
        //public Boolean PolicyPaymentisDue { get; set; }

        //[DisplayName("Policy Total Amount")]
        //public double PolicyTotalAmount { get; set; }

        //[DisplayName("Policy Paid Off Amount")]
        //public double PolicyPaidOffAmount { get; set; }

        //[DisplayName("Policy Start Date")]
        //public DateTime PolicyStart_Date { get; set; }

        //[DisplayName("Policy End Date")]
        //public DateTime PolicyEnd_Date { get; set; }

        //[DisplayName("Is Policy Pending")]
        //public Boolean Pending { get; set; }

    }
}
