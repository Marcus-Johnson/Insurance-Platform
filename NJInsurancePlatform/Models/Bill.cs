using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NJInsurancePlatform.Models
{
    public partial class Bill
    {
        [Key]
        [ScaffoldColumn(false)]
        public int BillMUID { get; set; }

        [ForeignKey("PolicyMUID")]
        [ScaffoldColumn(false)]
        public virtual int PolicyMUID { get; set; }

        [Required(ErrorMessage = "Missing - Policy Due Date")]
        public DateTime PolicyDueDate { get; set; }

        [Required(ErrorMessage = "Missing - Minimum Payment")]
        [Range(450.00, 10000.00, ErrorMessage = "Price must be between 450.00 and 10000.00")]
        public double MinimumPayment { get; set; }

        [Required(ErrorMessage = "Missing - Created Date")]
        public DateTime CreatedDate { get; set; }

        [Required(ErrorMessage = "Missing - Balance")]
        public double Balance { get; set; }

        [Required(ErrorMessage = "Missing - Status")]
        [StringLength(255)]
        public string? Status { get; set; }
    }
}
