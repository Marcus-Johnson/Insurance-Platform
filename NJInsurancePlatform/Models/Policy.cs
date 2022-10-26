using System.ComponentModel.DataAnnotations;

namespace NJInsurancePlatform.Models
{
    public partial class Policy
    {
        [Key]
        public Guid PolicyMUID { get; set; }

        [Required(ErrorMessage = "Missing - PolicyNumber")]
        public int PolicyNumber { get; set; }

        [Required(ErrorMessage = "Missing - Name Of Policy")]
        [StringLength(50)]
        public string NameOfPolicy { get; set; }

        [Required(ErrorMessage = "Missing - Policy Owner")]
        [StringLength(50)]
        public string PolicyOwner { get; set; }
        
        public Boolean PolicyPaymentisDue { get; set; }

        [Required(ErrorMessage = "Missing - Minimum Payment")]
        public double PolicyTotalAmount { get; set; }

        [Required(ErrorMessage = "Missing - Minimum Payment")]
        public double PolicyPaidOffAmount { get; set; }

        [Required(ErrorMessage = "Missing - Policy Due Date")]
        public DateTime PolicyStart_Date { get; set; }

        [Required(ErrorMessage = "Missing - Policy End Date")]
        public DateTime PolicyEnd_Date { get; set; }

    }
}
