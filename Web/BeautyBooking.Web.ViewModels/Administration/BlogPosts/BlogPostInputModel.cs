namespace BeautyBooking.Web.ViewModels.Administration.BlogPosts
{
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Http;

    public class BlogPostInputModel
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        [DataType(DataType.Upload)]
        public IFormFile Image { get; set; }
    }
}
