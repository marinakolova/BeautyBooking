namespace BeautyBooking.Data.Models
{
    using System.Collections.Generic;

    using BeautyBooking.Data.Common.Models;

    public class BlogPost : BaseDeletableModel<int>
    {
        public BlogPost()
        {
            this.Categories = new HashSet<BlogPostCategory>();
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public string ImageUrl { get; set; }

        public virtual ICollection<BlogPostCategory> Categories { get; set; }
    }
}
