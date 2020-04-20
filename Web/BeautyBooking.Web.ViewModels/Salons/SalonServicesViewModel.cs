namespace BeautyBooking.Web.ViewModels.Salons
{
    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Mapping;

    public class SalonServicesViewModel : IMapFrom<SalonService>
    {
        public int SalonId { get; set; }

        public string SalonName { get; set; }

        public int ServiceId { get; set; }

        public string ServiceName { get; set; }
    }
}
