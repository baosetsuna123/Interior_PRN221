using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Razor_Page.Models
{
    [Table("Material")]
    public class Material
    {
        [Key]
        public int MaterialID { get; set; }
        public string? Name { get; set; }
        public string? Image { get; set; }

        public virtual ICollection<InteriorDetail>? InteriorDetails { get; set;}


    }
}
