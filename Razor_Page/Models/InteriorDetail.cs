namespace Razor_Page.Models
{
    public class InteriorDetail
    {
        public int InteriorID { get; set; }
        public int MaterialID { get; set; }
        public double TotalPrice { get; set; }

        public Interior? Interior { get; set; }
        public Material? Material { get; set; }
    }
}
