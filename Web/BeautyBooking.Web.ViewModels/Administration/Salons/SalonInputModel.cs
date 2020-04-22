namespace BeautyBooking.Web.ViewModels.Administration.Salons
{
    using System.ComponentModel.DataAnnotations;

    using BeautyBooking.Web.Infrastructure.CustomValidationAttributes;
    using Microsoft.AspNetCore.Http;

    public class SalonInputModel
    {
        public string Name { get; set; }

        public string Category { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        [DataType(DataType.Upload)]
        [ValidateImageFile(ErrorMessage = "Please select a JPG, JPEG or PNG image smaller than 1MB")]
        public IFormFile Image { get; set; }
    }
}
