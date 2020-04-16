namespace BeautyBooking.Data.Models
{
    using System.Collections.Generic;

    using BeautyBooking.Data.Common.Models;

    public class BlogPost : BaseDeletableModel<int>
    {
        public BlogPost()
        {
            this.Comments = new HashSet<Comment>();
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public string ImageUrl { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
