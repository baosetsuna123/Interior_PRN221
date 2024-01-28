using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Razor_Page.Models
{
    [Table("Quotation")]
    public class Quotation
    {
        [Key]
        public int QuotationID { get; set; }

        public int CustomerID { get; set; }
        public DateTime RequestDate { get; set; }
        public double EstimatePrice { get; set; }
        public string? Content { get; set; }

        [ForeignKey(nameof(CustomerID))]
        public Customer? Customer { get; set; }

        public virtual ICollection<QuotationDetail>? QuotationDetails { get; set; }


    }
}
