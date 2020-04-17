namespace BeautyBooking.Web.ViewModels.Salons
{
    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Mapping;

    public class SalonViewModel : IMapFrom<Salon>
    {
        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public string Address { get; set; }
    }
}
