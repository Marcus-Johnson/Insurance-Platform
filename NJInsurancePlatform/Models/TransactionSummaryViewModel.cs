namespace NJInsurancePlatform.Models
{
    public class TransactionSummaryViewModel
    {
        public List<ApplicationUser> ApplicationUsers { get; set; }
        public List<Transaction> Transactions { get; set; }
        public List<Policy> Policies { get; set; }
        public List<string> FirstNames { get; set; }
        public List<string> LastNames { get; set; }
        public List<string> PolicyNames { get; set; }

        public TransactionSummaryViewModel()
        {
            ApplicationUsers = new List<ApplicationUser>();
            Transactions = new List<Transaction>();
            Policies = new List<Policy>();
            FirstNames = new List<string>();
            LastNames = new List<string>();
            PolicyNames = new List<string>();
        }
    }
}
