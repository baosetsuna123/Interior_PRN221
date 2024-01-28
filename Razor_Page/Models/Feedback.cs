using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Razor_Page.Models
{
    [Table("Feedback")]
    public class Feedback
    {
        [Key]
        public int FeedbackID { get; set; }
        public int? CustomerID { get; set; }
        public string? Content { get; set; }

        [ForeignKey("CustomerID")]
        public Customer? Customer { get; set; }


    }
}
