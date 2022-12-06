using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace NJInsurancePlatform.Models
{
    public class Payment
    {
        [Key]
        [ScaffoldColumn(false)]
        public Guid PaymentMUID { get; set; }

        [ForeignKey("BillMUID")]
        [ScaffoldColumn(false)]
        public virtual Guid BillMUID { get; set; }

        [Required(ErrorMessage = "Paid Date is required.")]
        [DisplayName("Paid Date")]
        public DateTime PaidDate { get; set; }

        [Required(ErrorMessage = "Amount is required.")]
        [DisplayName("Amount")]
        public double Amount { get; set; }

        [Required(ErrorMessage = "Payment Method is required.")]
        [DisplayName("Payment Method")]
        public string? PaymentMethod { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        [DisplayName("Payer First Name")]
        public string? PayerFirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        [DisplayName("Payer Last Name")]
        public string? PayerLastName { get; set; }

        [Required(ErrorMessage = "Missing - Card Number")]
        [RegularExpression("^[0-9]*$")]
        [StringLength(16)]
        [DisplayName("Card Number")]
        public string? CardNumber { get; set; }

        [Required(ErrorMessage = "Missing - CVV")]
        [RegularExpression("^[0-9]*$")]
        [StringLength(4)]
        [DisplayName("CVV")]
        public string? CVV { get; set; }

        [Required(ErrorMessage = "Missing - Zip Code")]
        [RegularExpression("^[0-9]*$")]
        [StringLength(10)]
        [DisplayName("Zip Code")]
        public string? ZipCode { get; set; }

        [Required(ErrorMessage = "Missing - Card Expire Date")]
        [DisplayName("Card Expire Date")]
        public DateTime CardExpireDate { get; set; }

        [Required(ErrorMessage = "Missing - Debit or Credit")]
        [DisplayName("Debit or Credit")]
        public string? DebitOrCredit { get; set; }

        [Required(ErrorMessage = "Missing - Bank Name")]
        [DisplayName("Bank Name")]
        public string? BankName { get; set; }

        [Required(ErrorMessage = "Missing - Account Number must be numeric.")]
        [RegularExpression("^[0-9]*$")]
        [DisplayName("Account Number")]
        public string? AccountNumber { get; set; }

        [Required(ErrorMessage = "Missing - Routing Number must be numeric.")]
        [StringLength(9)]
        [RegularExpression("^[0-9]*$")]
        [DisplayName("Routing Number")]
        public string? RoutingNumber { get; set; }

        [Required(ErrorMessage = "Missing - Check Number")]
        [DisplayName("Check Number")]
        public int CheckNumber { get; set; }

        [Required(ErrorMessage = "Missing - Check Image")]
        [DisplayName("Account Number")]
        public string? CheckImage { get; set; }

        [Required(ErrorMessage = "Additional Info is required.")]
        [DisplayName("Additional Info")]
        public string? AdditionalInfo { get; set; }

        [Required(ErrorMessage = "Created Date is required.")]
        [DisplayName("Created Date")]
        public DateTime CreatedDate { get; set; }
    }
}
