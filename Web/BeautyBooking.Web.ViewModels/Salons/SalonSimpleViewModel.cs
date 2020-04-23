namespace BeautyBooking.Web.ViewModels.Salons
{
    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Mapping;

    public class SalonSimpleViewModel : IMapFrom<Salon>
    {
        public string Id { get; set; }

        public string Name { get; set; }
    }
}
