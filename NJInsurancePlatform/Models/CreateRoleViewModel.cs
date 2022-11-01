using System.ComponentModel.DataAnnotations;

namespace NJInsurancePlatform.Models
{
    public class CreateRoleViewModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}
