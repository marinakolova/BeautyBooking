namespace BeautyBooking.Web.ViewModels.Administration.BlogPosts
{
    using System.ComponentModel.DataAnnotations;

    using BeautyBooking.Web.Infrastructure.CustomValidationAttributes;
    using Microsoft.AspNetCore.Http;

    public class BlogPostInputModel
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        [DataType(DataType.Upload)]
        [ValidateImageFile(ErrorMessage = "Please select a JPG, JPEG or PNG image smaller than 1MB")]
        public IFormFile Image { get; set; }
    }
}
