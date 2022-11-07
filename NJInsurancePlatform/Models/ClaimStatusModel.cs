using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace NJInsurancePlatform.Models
{
    public class ClaimStatusModel
    {
        [Key]
        [ScaffoldColumn(false)]
        [DisplayName("ClaimMUID")]
        public Guid ClaimMUID { get; set; }

        [Required(ErrorMessage = "Missing field: Is Pending")]
        [DisplayName("Is Pending")]
        public bool isPending { get; set; } = true;

        [Required(ErrorMessage = "Missing field: Is Complete")]
        [DisplayName("Is Complete")]
        public bool isComplete { get; set; }
    }
}
