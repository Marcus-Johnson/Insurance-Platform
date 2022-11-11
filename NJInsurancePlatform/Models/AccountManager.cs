using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace NJInsurancePlatform.Models
{
    public class AccountManager
    {
        public AccountManager()
        {
            this.Transactions = new List<Transaction>();
        }

        [Key]
        [ScaffoldColumn(false)]
        public Guid AccountManagerMUID { get; set; }

        [DisplayName("First Name")]
        [Required(ErrorMessage = "Missing - First Name")]
        public string? FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Missing - Last Name")]
        public string? LastName { get; set; }

        [DisplayName("Gender")]
        [Required(ErrorMessage = "Missing - Gender")]
        public string? Gender { get; set; }

        [DisplayName("Created Date")]
        [Required(ErrorMessage = "Missing - Created Date")]
        public DateTime CreatedDate { get; set; }

        [DisplayName("List of Customer MUIDs")]
        [Required(ErrorMessage = "Missing - List of Customer MUIDs")]
        public IEnumerable<Customer>? ListOfCustomerMUIDs { get; set; }

        [DisplayName("Active")]
        [Required(ErrorMessage = "Missing - Active")]
        public bool Active { get; set; }

        [DisplayName("Unpaid Transaction")]
        public IEnumerable<Transaction>? Transactions { get; set; }
    }
}
