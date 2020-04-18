namespace BeautyBooking.Web.ViewModels.Owner.SalonManager
{
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Http;

    public class SalonInputModel
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public int CategoryId { get; set; }

        [DataType(DataType.Upload)]
        public IFormFile Image { get; set; }
    }
}
