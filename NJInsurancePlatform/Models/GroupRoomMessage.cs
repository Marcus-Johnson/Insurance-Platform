using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NJInsurancePlatform.Models
{
    public class GroupRoomMessage
    {
        [Key]
        [ScaffoldColumn(false)]
        [DisplayName("Group Room Message MUID")]
        public Guid GroupRoomMessageMUID { get; set; }

        [ForeignKey("GroupRoom")]
        [ScaffoldColumn(false)]
        [DisplayName("GroupMUID")]
        public Guid GroupRoomMUID { get; set; }

        [ScaffoldColumn(false)]
        [Required(ErrorMessage = "Missing field: Sender MUID")]
        public Guid SenderMUID { get; set; }        
        
        [Required(ErrorMessage = "Missing field: First Name")]
        public string FirstName { get; set; }        
        
        [Required(ErrorMessage = "Missing field: Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Missing field: Message")]
        [StringLength(140)]
        [DisplayName("Message")] 
        public string? Message { get; set; }

        [Required(ErrorMessage = "Missing field: DateTime")]
        public DateTime CreatedDate { get; set; } 


    }
}
