namespace BeautyBooking.Web.ViewModels.Manager.Salons
{
    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Mapping;

    public class SalonViewModel : IMapFrom<Salon>
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string CategoryName { get; set; }

        public string CityName { get; set; }

        public string Address { get; set; }

        public string ImageUrl { get; set; }
    }
}
