using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NJInsurancePlatform.Models
{
    public class GroupRoomIDsCross
    {
        [Key]
        [ScaffoldColumn(false)]
        public Guid GroupRoomMUID { get; set; }

        [ForeignKey("AccountManagerMUID")]
        [ScaffoldColumn(false)]
        public Guid AccountManagerMUID { get; set; }

        [ForeignKey("CustomerMUID")]
        [ScaffoldColumn(false)]
        public Guid CustomerMUID { get; set; }

        [ForeignKey("BeneficiaryMUID")]
        [ScaffoldColumn(false)]
        public Guid BeneficiaryMUID { get; set; }
    }
}
