using System.ComponentModel.DataAnnotations;

namespace NJInsurancePlatform.Models
{
    public class PolicyModel
    {
        [Key]

        public Guid PolicyMUID { get; set; }

        public int PolicyNumber { get; set; }

        public string NameOfPolicy { get; set; }

        public string PolicyOwner { get; set; }

        public Boolean PolicyPaymentisDue { get; set; }

        public double PolicyTotalAmount { get; set; }

        public double PolicyPaidOffAmount { get; set; }

        public DateTime PolicyStart_Date { get; set; }

        public DateTime PolicyEnd_Date { get; set; }

    }
}
