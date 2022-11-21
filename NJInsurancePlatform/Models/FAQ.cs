using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace NJInsurancePlatform.Models
{
    public class Faq
    {
        [Key]
        [ScaffoldColumn(false)]
        public Guid FaqMUID { get; set; }

        [DisplayName("Question")]
        [Required(ErrorMessage = "Missing - Question")]
        public string? Question { get; set; }

        [DisplayName("Answer")]
        [Required(ErrorMessage = "Missing - Answer")]
        public string? Answer { get; set; }

        //[DisplayName("Date Created")]
        //[Required(ErrorMessage = "Missing - Date Created")]
        //public TimestampAttribute DateCreated { get; set; }
    }
}
