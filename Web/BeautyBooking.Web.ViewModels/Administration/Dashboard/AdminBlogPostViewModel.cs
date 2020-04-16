namespace BeautyBooking.Web.ViewModels.Administration.Dashboard
{
    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Mapping;

    public class AdminBlogPostViewModel : IMapFrom<BlogPost>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public string ImageUrl { get; set; }
    }
}
