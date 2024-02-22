using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessObjects.Models
{
    [Table("Customer")]
    public class Customer
    {
        [Key]

        public int CustomerID { get; set; }

        public string? Name { get; set; }

        public string? Address { get; set; }

        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Image { get; set; }

        public virtual ICollection<Contract>? Contracts { get; set; }
        public virtual ICollection<Quotation>? Quotations { get; set; }


    }
}
