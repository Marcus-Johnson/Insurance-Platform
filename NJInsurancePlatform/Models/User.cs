using System.ComponentModel.DataAnnotations;

namespace NJInsurancePlatform.Models
{
    // PLACEHOLDER USER JUST FOR THE PURPOSE OF TESTING FUNCTIONALITY OF CODE
    public partial class User
    {
        //Key May or May not be needed
        //[Key]
        public int Id { get; set; }
        [Required]
        public string? UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}
