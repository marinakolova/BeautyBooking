namespace BeautyBooking.Data.Models
{
    using BeautyBooking.Data.Common.Models;

    public class BlogPost : BaseDeletableModel<int>
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public string ImageUrl { get; set; }
    }
}
