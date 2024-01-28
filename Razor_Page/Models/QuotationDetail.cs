namespace Razor_Page.Models
{
    public class QuotationDetail
    {
        public int InteriorID { get; set; }
        public int QuotationID { get; set; }

        public Interior? Interior { get; set; }
        public Quotation? Quotation { get; set; }
    }
}
