namespace BeautyBooking.Data.Models
{
    using BeautyBooking.Data.Common.Models;

    public class Comment : BaseDeletableModel<int>
    {
        public string Text { get; set; }

        public string AuthorId { get; set; }

        public virtual ApplicationUser Author { get; set; }

        public int BlogPostId { get; set; }

        public virtual BlogPost BlogPost { get; set; }
    }
}
