using Microsoft.AspNetCore.Identity;

namespace NJInsurancePlatform.Models
{
    public class PaymentViewModel
    {
        public Payment? Payment { get; set; }
        public Policy? Policy { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }
        public Bill? Bill { get; set; }
        public List<Bill>? Bills { get; set; }
        public PaymentViewModel()
        {
            this.Payment = new Payment();
            this.Policy = new Policy();
            this.ApplicationUser = new ApplicationUser();
            this.Bill = new Bill();
            this.Bills = new List<Bill>();
        }
    }
}
