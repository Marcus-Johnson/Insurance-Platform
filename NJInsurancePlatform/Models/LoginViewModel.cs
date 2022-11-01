using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;

namespace NJInsurancePlatform.Models
{
    // Login "View" Will Bind To this Class
    [AllowAnonymous]
    public class LoginViewModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
