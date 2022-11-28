using System.ComponentModel.DataAnnotations;

namespace NJInsurancePlatform.Models
{
    public class CustomerPolicyRequestViewModel
    {
        [Key]
        public Product? Product { get; set; }
        public Customer? Customer { get; set; }
        public PolicyRequest? PolicyRequest { get; set; }
        public CustomerPolicyRequestViewModel()
        {
            this.Product = new Product();
            this.Customer = new Customer();
            this.PolicyRequest = new PolicyRequest();
        }
    }
}
