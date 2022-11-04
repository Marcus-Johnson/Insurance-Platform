using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NJInsurancePlatform.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Extended Attributes HERE
        [Required]
        [DataType(DataType.Password)]
        [DisplayName("Enter Password")]
        public string Password { get; set; }
    }
}
