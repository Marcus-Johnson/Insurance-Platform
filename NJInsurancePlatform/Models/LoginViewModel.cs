using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;

namespace NJInsurancePlatform.Models
{
    // Login "View" Will Bind To this Class
    [AllowAnonymous]
    public class LoginViewModel
    {
        [Key]
        public Guid loginMUID { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string? PasswordHash { get; set; }
    }
}
