using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NJInsurancePlatform.Models
{
    public class Bill
    {
        [Key]
        [ScaffoldColumn(false)]
        public Guid BillMUID { get; set; }

        [ForeignKey("CustomerMUID")]
        [ScaffoldColumn(false)]
        public virtual Guid CustomerMUID { get; set; }

        [ForeignKey("PolicyMUID")]
        [ScaffoldColumn(false)]
        public virtual Guid PolicyMUID { get; set; }

        [Required(ErrorMessage = "Missing - Policy Due Date")]
        [DisplayName("Policy Due Date")]
        public DateTime PolicyDueDate { get; set; }

        [Required(ErrorMessage = "Missing - Minimum Payment")]
        [Range(450.00, 10000.00, ErrorMessage = "Price must be between 450.00 and 10000.00")]
        [DisplayName("Minumim Payment")]
        public double MinimumPayment { get; set; }

        [Required(ErrorMessage = "Missing - Created Date")]
        [DisplayName("Created at Date")]
        public DateTime CreatedDate { get; set; }

        [Required(ErrorMessage = "Missing - Balance")]
        [DisplayName("Balance")]
        public double Balance { get; set; }

        [Required(ErrorMessage = "Missing - Status")]
        [StringLength(255)]
        [DisplayName("Status")]
        public string? Status { get; set; }
    }
}
