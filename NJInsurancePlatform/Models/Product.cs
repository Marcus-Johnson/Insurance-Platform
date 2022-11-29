using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NJInsurancePlatform.Models
{
    public class Product
    {
        [Key]
        [ScaffoldColumn(false)]
        public Guid ProductMUID { get; set; }

        [DisplayName("Product Name")]
        [Required]
        public string? ProductName { get; set; }

        [DisplayName("Product Description")]
        [StringLength(100)]
        [Required(ErrorMessage = "Missing - Description")]
        public string? Description { get; set; }

        [DisplayName("Name Of Policy")]
        [Required(ErrorMessage = "Missing - Name Of Policy")]
        public double? Price { get; set; }

        [DisplayName("Deductible ")]
        [Required(ErrorMessage = "Missing - Deductible ")]
        public double? Deductible { get; set; }

        [DisplayName("Annual Limit Of Coverage")]
        [Required(ErrorMessage = "Missing - Out Of Pocket Limit")]
        public double? AnnualLimitOfCoverage { get; set; }

        [DisplayName("Out Of Pocket Limit")]
        [Required(ErrorMessage = "Missing - Annual Limit Of Coverage")]
        public double? OutOfPocketLimit { get; set; }

        [DisplayName("Policy Paid Off Amount")]
        [Required(ErrorMessage = "Missing - Minimum Payment")]
        public double PolicyPaidOffAmount { get; set; }

        [DisplayName("Policy Total Amount")]
        [Required(ErrorMessage = "Missing - Minimum Payment")]
        public double PolicyTotalAmount { get; set; }
    }
}
