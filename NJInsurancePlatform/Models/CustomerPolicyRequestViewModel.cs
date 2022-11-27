namespace NJInsurancePlatform.Models
{
    public class CustomerPolicyRequestViewModel
    {
        private Product? Product { get; set; }
        private Customer? Customer { get; set; }
        private PolicyRequest? PolicyRequest { get; set; }
        public CustomerPolicyRequestViewModel()
        {
            this.Product = new Product();
            this.Customer = new Customer();
            this.PolicyRequest = new PolicyRequest();
        }
    }
}
