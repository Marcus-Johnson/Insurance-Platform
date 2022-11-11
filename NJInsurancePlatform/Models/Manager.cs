namespace NJInsurancePlatform.Models
{
    public class Manager
    {
        public IEnumerable<Receipt>? GetReceipts()
        {
            return Receipts;
        }

        public string? Id { get; set; }
        IEnumerable<Receipt>? Receipts { get; set; }
    }
}
