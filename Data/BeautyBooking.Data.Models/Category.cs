namespace BeautyBooking.Data.Models
{
    using System.Collections.Generic;

    using BeautyBooking.Data.Common.Models;

    public class Category : BaseDeletableModel<int>
    {
        public Category()
        {
            this.Salons = new HashSet<Salon>();
            this.BlogPosts = new HashSet<BlogPostCategory>();
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public virtual ICollection<Salon> Salons { get; set; }

        public virtual ICollection<BlogPostCategory> BlogPosts { get; set; }
    }
}
