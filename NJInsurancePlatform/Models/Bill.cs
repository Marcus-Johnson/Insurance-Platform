using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NJInsurancePlatform.Models
{
    public partial class Bill
    {
        [Key]
        public int BillMUID { get; set; }

        [ForeignKey("PolicyMUID")]
        public virtual int PolicyMUID { get; set; }

        [Required]
        public DateTime PolicyDueDate { get; set; }

        [Required]
        public double MinimumPayment { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        public double Balance { get; set; }

        [Required]
        [StringLength(255)]
        public string? Status { get; set; }
    }
}
