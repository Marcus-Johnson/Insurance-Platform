namespace NJInsurancePlatform.Models
{
    public class AllTransactionsViewModel
    {
        public List<ApplicationUser>? ApplicationUsers { get; set; }
        public List<Transaction>? Transactions { get; set; }
        public List<Policy>? Policies { get; set; }
        public List<string>? FirstName { get; set; }
        public List<string>? LastName { get; set; }
        public List<string>? NameOfPolicy { get; set; }

        public AllTransactionsViewModel()
        {
            this.ApplicationUsers = new List<ApplicationUser>();
            this.Transactions = new List<Transaction>();
            this.Policies = new List<Policy>();
            this.FirstName = new List<string>();
            this.LastName = new List<string>();
            this.NameOfPolicy = new List<string>();
        }
    }

}
