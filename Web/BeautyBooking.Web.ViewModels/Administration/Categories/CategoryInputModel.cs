namespace BeautyBooking.Web.ViewModels.Administration.Categories
{
    using System.ComponentModel.DataAnnotations;

    using BeautyBooking.Web.Infrastructure.CustomValidationAttributes;
    using Microsoft.AspNetCore.Http;

    public class CategoryInputModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        [DataType(DataType.Upload)]
        [ValidateImageFile(ErrorMessage = "Please select a JPG, JPEG or PNG image smaller than 1MB")]
        public IFormFile Image { get; set; }
    }
}
