namespace BeautyBooking.Data.Models
{
    using BeautyBooking.Data.Common.Models;

    public class BlogPostCategory : BaseDeletableModel<int>
    {
        public int BlogPostId { get; set; }

        public virtual BlogPost BlogPost { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
