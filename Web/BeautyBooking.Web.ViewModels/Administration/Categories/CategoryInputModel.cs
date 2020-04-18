namespace BeautyBooking.Web.ViewModels.Administration.Categories
{
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Http;

    public class CategoryInputModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        [DataType(DataType.Upload)]
        public IFormFile Image { get; set; }
    }
}
