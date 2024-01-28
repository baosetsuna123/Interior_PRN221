using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Razor_Page.Models
{
    [Table("Contract")]
    public class Contract
    {
        [Key]
        public int ContractID { get; set; } 

        public DateTime AgreementDate  {get; set; }

    public string? Content { get; set; }

        public bool status { get; set; }

        public int? CustomerID { get; set; }

        [ForeignKey("CustomerID")]

        public Customer? Customer { get; set; }

    }
}
