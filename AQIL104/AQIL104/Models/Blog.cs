namespace AQIL104.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }

        public string ByWho { get; set; }
       
        public DateTime DateTime { get; set; }

    }
}
