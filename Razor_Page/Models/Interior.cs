using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Razor_Page.Models
{
    [Table("Interior")]
    public class Interior
    {
        [Key]
        public int InteriorID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public virtual ICollection<InteriorDetail>? InteriorDetails { get; set; } 
        public virtual ICollection<QuotationDetail>? QuotationDetails { get; set; } 
    }
}
