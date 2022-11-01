using Microsoft.AspNetCore.Identity;

namespace NJInsurancePlatform.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Extended Attributes HERE
        public string ExtendedAttribueExample { get; set; }
    }
}
