using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace NJInsurancePlatform.Models
{
    public class Transaction
    {
        [Key]
        [ScaffoldColumn(false)]
        public Guid TransactionMUID { get; set; }

        [ForeignKey("PolicyMUID")]
        [ScaffoldColumn(false)]
        public Guid CustomerMUID { get; set; }

        [ForeignKey("PolicyMUID")]
        [ScaffoldColumn(false)]
        public Guid PolicyMUID { get; set; }

        [Required(ErrorMessage = "Required")]
        [DisplayName("Is Payment Complete?")]
        public bool isPaymentComplete { get; set; }

        [Required(ErrorMessage = "Required")]
        [DisplayName("Payment Amount")]
        public double PaymentAmount { get; set; }

        [Required(ErrorMessage = "Required")]
        [DisplayName("Payment Date")]
        public DateTime PaymentDate { get; set; }

        [DisplayName("List of Policy Beneficiaries MUIDs")]
        [Required(ErrorMessage = "Missing - List of Policy Beneficiaries MUIDs")]
        public IEnumerable<Beneficiary>? ListOfPolicyBeneficiariesMUIDs { get; set; }
    }
}
