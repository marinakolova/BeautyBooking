namespace BeautyBooking.Web.ViewModels.Home
{
    using System;

    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Mapping;

    public class IndexBlogViewModel : IMapFrom<BlogPost>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public DateTime CreatedOn { get; set; }

        public string ImageUrl { get; set; }

        public int CommentsCount { get; set; }
    }
}
