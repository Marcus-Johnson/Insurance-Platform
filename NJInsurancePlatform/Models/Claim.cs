using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace NJInsurancePlatform.Models
{
    public class Claim
    {
        [Key]
        [ScaffoldColumn(false)]
        [DisplayName("Claim Id")]
        public Guid ClaimMUID { get; set; }

        [ForeignKey("CustomerMUID")]
        [ScaffoldColumn(false)]
        public string? CustomerMUID { get; set; }

        [ForeignKey("PolicyMUID")]
        [ScaffoldColumn(false)]
        public string? PolicyMUID { get; set; }

        [Required(ErrorMessage = "Missing Field: Claim Description")]
        [StringLength(500)]
        [DisplayName("Claim Description")]
        public string? ClaimUserDescription { get; set; }

        [Required(ErrorMessage = "Missing field: Date Of Claim")]
        [DisplayName("Date Of Claim")]
        public DateTime DateOfClaim { get; set; }
    }

}
