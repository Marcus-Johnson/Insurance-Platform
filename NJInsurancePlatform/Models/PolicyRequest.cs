using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NJInsurancePlatform.Models
{
    public class PolicyRequest
    {
        [Key]
        [ScaffoldColumn(false)]
        public Guid RequestMUID { get; set; }

        [ForeignKey("CustomerMUID")]
        [ScaffoldColumn(false)]
        public Guid CustomerMUID { get; set; }

        [ForeignKey("PolicyMUID")]
        [ScaffoldColumn(false)]
        public Guid PolicyMUID { get; set; }

        [Required(ErrorMessage = "Missing - Created Date")]
        [DisplayName("Created at Date")]
        public DateTime CreationDate { get; set; }

    }
}