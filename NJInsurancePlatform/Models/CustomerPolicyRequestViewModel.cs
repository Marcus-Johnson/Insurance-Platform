using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NJInsurancePlatform.Models
{
    public class CustomerPolicyRequestViewModel
    {
        public Product Product { get; set; }
        public ApplicationUser Customer { get; set; }
        public PolicyRequest PolicyRequest { get; set; }
        public List<Bill> Bills { get; set; }
        public CustomerPolicyRequestViewModel()
        {
            this.Product = new Product();
            this.Customer = new ApplicationUser();
            this.PolicyRequest = new PolicyRequest();
            this.Bills = new List<Bill>();
        }

    }
}
