using System.ComponentModel.DataAnnotations;

namespace NJInsurancePlatform.Models
{
    public class Policy
    {
        [Key]
        [ScaffoldColumn(false)]
        public Guid PolicyMUID { get; set; }

        [DisplayName("PolicyNumber")]
        [Required(ErrorMessage = "Missing - PolicyNumber")]
        public int PolicyNumber { get; set; }

        [DisplayName("NameOfPolicy")]
        [Required(ErrorMessage = "Missing - Name Of Policy")]
        [StringLength(50)]
        public string NameOfPolicy { get; set; }

        [DisplayName("PolicyOwner")]
        [Required(ErrorMessage = "Missing - Policy Owner")]
        [StringLength(50)]
        public string PolicyOwner { get; set; }

        [DisplayName("PolicyPaymentisDue")]
        public Boolean PolicyPaymentisDue { get; set; }

        [DisplayName("PolicyTotalAmount")]
        [Required(ErrorMessage = "Missing - Minimum Payment")]
        public double PolicyTotalAmount { get; set; }

        [DisplayName("PolicyPaidOffAmount")]
        [Required(ErrorMessage = "Missing - Minimum Payment")]
        public double PolicyPaidOffAmount { get; set; }

        [DisplayName("PolicyStart_Date")]
        [Required(ErrorMessage = "Missing - Policy Due Date")]
        public DateTime PolicyStart_Date { get; set; }

        [DisplayName("PolicyEnd_Date")]
        [Required(ErrorMessage = "Missing - Policy End Date")]
        public DateTime PolicyEnd_Date { get; set; }

    }
}
