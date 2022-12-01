namespace NJInsurancePlatform.Models
{
    public class CustomerHomePageVieModel
    {
        public List<Policy>? Policies { get; set; }
        public List<Transaction>? Transactions { get; set; }
        public List<Beneficiary>? Beneficiaries { get; set; }
        public List<string>? PolicyNames  { get; set; }
        public CustomerHomePageVieModel()
        {
            this.Policies = new List<Policy>();
            this.Transactions = new List<Transaction>();
            this.PolicyNames = new List<string>();
            this.Beneficiaries = new List<Beneficiary>();
        }
        public string? ClaimUserDescription { get; set; }
    }
}
