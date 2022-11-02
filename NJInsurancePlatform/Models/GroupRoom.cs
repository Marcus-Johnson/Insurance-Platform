using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NJInsurancePlatform.Models
{
    public class GroupRoom
    {
        [Key]
        [ScaffoldColumn(false)]
        [DisplayName("Group MUID")]
        public Guid GroupMUID { get; set; }

        [Required(ErrorMessage = "Missing field: Name")]
        [StringLength(140)]
        [DisplayName("Name")]
        public string? Name { get; set; }
    }
}
