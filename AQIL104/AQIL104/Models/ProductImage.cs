namespace AQIL104.Models
{
    public class ProductImage
    {
        public int id { get; set; }
        public string Url { get; set; }
        public string Alternative { get; set; }
        
        public int ProductId { get; set; }
        public bool? IsPrimary { get; set; }
        public Product Product { get; set; }
    }
}
