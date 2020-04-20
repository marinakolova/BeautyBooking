namespace BeautyBooking.Web.ViewModels.Administration.Salons
{
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Http;

    public class SalonInputModel
    {
        public string Name { get; set; }

        public string Category { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        [DataType(DataType.Upload)]
        public IFormFile Image { get; set; }
    }
}
